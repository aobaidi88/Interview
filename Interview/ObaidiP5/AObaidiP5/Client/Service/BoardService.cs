using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AObaidiP5.Client.Service;
using AObaidiP5.Shared;

namespace AObaidiP5.Client.Service
{
    public class BoardService : IBoardService
    {
        private readonly HttpClient httpClient;

        public BoardService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task AddBoard(SnowBoard snowBoard)
        {
            await this.httpClient.PostAsJsonAsync("api/SnowBoards", snowBoard);
        }
        public async Task<List<SnowBoard>> GetBoards()
        {
            var board = await this.httpClient.GetFromJsonAsync<List<SnowBoard>>("api/SnowBoards");
            return board;
        }
    }
}
