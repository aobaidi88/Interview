using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AObaidiP5.Shared
{
   public interface IBoardService
    {
        Task<List<SnowBoard>> GetBoards();
        public Task AddBoard(SnowBoard snowBoard);
    }
}
