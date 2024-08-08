using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarAuctionApplication.Contracts.IRepositories;
using CarAuctionApplication.Contracts.IServices;
using CarAuctionApplication.Models.Main.Dtos.Auction;
using CarAuctionApplication.Models.Main.Dtos.CarAuction;
using CarAuctionApplication.Models.QueryParameters;
using CarAuctionApplication.Service.Mapper;
using CarAuctionEntities.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;


namespace CarAuctionApplication.Service.Implementations
{
    public class AuctionService : IAuctionService
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly IMapper _mapper;
        public AuctionService(MappingProfile mappingProfile, IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
            _mapper = mappingProfile.InitilizeAuction();
        }
        public async Task<List<AuctionForGettingDtoAll>> GetAllAuctionsAsync(AuctionQueryParameters queryParameters)
        {
            IQueryable<Auction> query = _auctionRepository.GetQuery("AuctionItem");

            if (queryParameters.SearchParameters != null && queryParameters.SearchParameters.Count > 0)
            {
                query = ApplyFiltering(query, queryParameters.SearchParameters);
            }


            if (!string.IsNullOrEmpty(queryParameters.SortParameters.SortBy))
            {
                query = ApplySorting(query, queryParameters.SortParameters.SortBy, queryParameters.SortParameters.Descending);
            }

            query = ApplyPaging(query, queryParameters.PageParameters.PageNumber, queryParameters.PageParameters.PageSize);

            var auctions = await query.ToListAsync();
            var result = _mapper.Map<List<AuctionForGettingDtoAll>>(auctions);

            return result;
        }


        public async Task<AuctionForGettingDtoSingle> GetSingleAuctionAsync(Guid id)
        {
            var raw = await _auctionRepository.GetAsync(x => x.Id == id, includePropeties: "AuctionItem,AuctionItem.Images,AuctionItem.AdditionalProperties");
            if (raw is null)
            {
                throw new Exception("Auction not Found");
            }
            var Auction = _mapper.Map<AuctionForGettingDtoSingle>(raw);
            return Auction;
        }
        public async Task CreateAuctionAsync(AuctionForCreatingDto auctionForCreatingDto)
        {
            if (auctionForCreatingDto is null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }
            var result = _mapper.Map<Auction>(auctionForCreatingDto);
            /*var userId = _userRepository.AuthenticatedUserId();
            if (userId is null)
            {
                throw new UnauthorizedAccessException("Must be logged in to create topic");
            }*/
            result.SellerId = "1365FCBA-5EBF-45B9-B67C-11DC33B91B12";
            await _auctionRepository.AddAsync(result);
            await _auctionRepository.Save();
        }
        /*public IQueryable<AuctionForGettingDtoAll> GetAllAuctionsQueryable()
        {
            var query = _auctionRepository.GetQuery();

            return query.ProjectTo<AuctionForGettingDtoAll>(_mapper.ConfigurationProvider);

        }*/
        public async Task DeleteAuctionAsync(Guid auctionId)
        {
            if (auctionId == Guid.Empty)
            {
                throw new ArgumentException("Invalid argument passed");
            }
            var raw = await _auctionRepository.GetAsync(x => x.Id == auctionId, includePropeties: "AuctionItem,AuctionItem.Images,AuctionItem.AdditionalProperties");
            if (raw == null)
            {
                throw new Exception("Auction not Found");
            }
            /*var userId = _userRepository.AuthenticatedUserId();
            var userRole = _userRepository.AuthenticatedUserRole().Trim();
            if (userId is null)
            {
                throw new UnauthorizedAccessException("Must be logged in to update state of topic");
            }
            if (raw.UserId.Trim() != userId && userRole != "Admin")
            {
                throw new InvalidUserException("Can't delete different users topic");
            }*/
            else
            {
                _auctionRepository.Remove(raw);
                await _auctionRepository.Save();
            }
        }
        public async Task UpdateAuctionAsyncSeller(Guid auctionId, AuctionForUpdatingDtoSeller auctionForUpdatingDtoSeller)
        {
            if (auctionForUpdatingDtoSeller is null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }
            /*var authenticatedId = _userRepository.AuthenticatedUserId();
            if (authenticatedId is null)
            {
                throw new UnauthorizedAccessException("Must be logged in to update Topic");
            }*/
            var auctionFromDb = await _auctionRepository.GetAsync(x => x.Id == auctionId, includePropeties: "AuctionItem,AuctionItem.Images,AuctionItem.AdditionalProperties");
            if (auctionFromDb is null)
            {
                throw new Exception("Auction not Found");
            }
            /*if (auctionFromDb.UserId != authenticatedId)
            {
                throw new UnauthorizedAccessException("Can't update another users topic");
            }*/
            _mapper.Map(auctionForUpdatingDtoSeller, auctionFromDb);

            await _auctionRepository.Update(auctionFromDb);
            await _auctionRepository.Save();
        }
        private IQueryable<T> ApplySorting<T>(IQueryable<T> query, string sortBy, bool descending) where T : class
        {
            if (string.IsNullOrEmpty(sortBy))
            {
                return query;
            }

            var param = Expression.Parameter(typeof(T), "x");
            var properties = sortBy.Split('.');
            Expression property = param;

            // Traverse the nested properties
            foreach (var prop in properties)
            {
                property = Expression.Property(property, prop);
            }

            var lambda = Expression.Lambda(property, param);
            string methodName = descending ? "OrderByDescending" : "OrderBy";

            MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { typeof(T), property.Type }, query.Expression, Expression.Quote(lambda));
            return query.Provider.CreateQuery<T>(resultExp);
        }
        private IQueryable<T> ApplyPaging<T>(IQueryable<T> query, int pageNumber, int pageSize) where T : class
        {
            if (pageNumber < 1 || pageSize < 1)
            {
                throw new ArgumentException("Page number and page size must be greater than 0.");
            }

            int skip = (pageNumber - 1) * pageSize;
            return query.Skip(skip).Take(pageSize);
        }
        private IQueryable<T> ApplyFiltering<T>(IQueryable<T> query, List<SearchParameters> filters) where T : class
        {
            if (filters == null || filters.Count == 0)
            {
                return query;
            }

            foreach (var filter in filters)
            {
                if (string.IsNullOrEmpty(filter.FilterBy) || string.IsNullOrEmpty(filter.FilterValue))
                {
                    continue;
                }

                var param = Expression.Parameter(typeof(T), "x");
                Expression property = param;

                // Navigate through nested properties
                foreach (var propName in filter.FilterBy.Split('.'))
                {
                    property = Expression.Property(property, propName);
                }

                // Determine the comparison operator and value
                var filterValue = filter.FilterValue.Trim();
                object value;
                Expression? comparison = null;

                if (filterValue.StartsWith(">="))
                {
                    value = ConvertToType(filterValue.Substring(2).Trim(), property.Type);
                    comparison = Expression.GreaterThanOrEqual(property, Expression.Constant(value));
                }
                else if (filterValue.StartsWith("<="))
                {
                    value = ConvertToType(filterValue.Substring(2).Trim(), property.Type);
                    comparison = Expression.LessThanOrEqual(property, Expression.Constant(value));
                }
                else if (filterValue.StartsWith(">"))
                {
                    value = ConvertToType(filterValue.Substring(1).Trim(), property.Type);
                    comparison = Expression.GreaterThan(property, Expression.Constant(value));
                }
                else if (filterValue.StartsWith("<"))
                {
                    value = ConvertToType(filterValue.Substring(1).Trim(), property.Type);
                    comparison = Expression.LessThan(property, Expression.Constant(value));
                }
                else
                {
                    value = ConvertToType(filterValue, property.Type);
                    comparison = Expression.Equal(property, Expression.Constant(value));
                }

                var lambda = Expression.Lambda<Func<T, bool>>(comparison, param);
                query = query.Where(lambda);
            }

            return query;
        }


        private object ConvertToType(string value, Type type)
        {
            var converter = TypeDescriptor.GetConverter(type);

            // Check for valid format and handle accordingly
            if (type == typeof(DateTime))
            {
                if (DateTime.TryParse(value, out var dateValue))
                {
                    return dateValue;
                }
                throw new FormatException($"Cannot convert '{value}' to type '{type.Name}'.");
            }
            var result = converter.ConvertFromString(value);
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            return result;
        }
    }
}
