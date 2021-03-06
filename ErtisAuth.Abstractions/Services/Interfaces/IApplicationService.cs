using System.Threading.Tasks;
using ErtisAuth.Core.Models.Applications;

namespace ErtisAuth.Abstractions.Services.Interfaces
{
	public interface IApplicationService : IMembershipBoundedCrudService<Application>
	{
		Application GetById(string id);
		
		Task<Application> GetByIdAsync(string id);
	}
}