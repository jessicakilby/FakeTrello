using FakeTrello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTrello.Controllers.Contracts
{
    public interface IListRepository
    {
        #region
        // Create methods
        void AddList(string name, Board board);
        void AddList(string name, int boardId);
        #endregion

        // read methods
        List GetList(int listId);
        List<List> GetListsFromBoard(int boardId); // List of Trello Lists

        bool RemoveList(int listId);
    }
}
