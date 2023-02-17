﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Web_Api.online.Models.Tables;

namespace Web_Api.online.Data.Repositories.Abstract
{
    public interface IOutcomeTransactionRepository
    {
        public Task<OutcomeTransactionTableModel> CreateOutcomeTransaction(OutcomeTransactionTableModel outcomeTransaction);

        public Task UpdateOutcomeTransactionAfterExecutionAsync(OutcomeTransactionTableModel outcomeTransaction);

        public Task<List<OutcomeTransactionTableModel>> GetOutcomeTransactionsPaged(int page, int pageSize);

        public Task<int> GetCountOfOutcomeTransactions();

        public Task<List<OutcomeTransactionTableModel>> GetOutcomeTransactionsByUserIdPaged(string userId, int page, int pageSize);

    }
}
