using Microsoft.EntityFrameworkCore;

namespace WebCalcul.Data
{
	public class HistoryService
	{
		private readonly WebCalculDbContext _dbContext;

		public HistoryService(WebCalculDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<CalculState>> GetHistoryAsync()
		{
			// returns values from db table in reverse order
			return await _dbContext.CalculStates.OrderByDescending(x => x.Id).ToListAsync();
		}

		public async Task DeleteAllCalculStatesAsync()
		{
			var allCalculStates = await _dbContext.CalculStates.ToListAsync();

			_dbContext.CalculStates.RemoveRange(allCalculStates);

			await _dbContext.SaveChangesAsync();
		}
	}
}
