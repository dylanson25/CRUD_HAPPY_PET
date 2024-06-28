using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_HAPPY_PET.Views;
using CRUD_HAPPY_PET.Models;
using CRUD_HAPPY_PET.Repositories;

namespace CRUD_HAPPY_PET.Presenters
{
  public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnection;

        public MainPresenter(IMainView mainView, string sqlConnection)
        {
            this.mainView = mainView;
            this.sqlConnection = sqlConnection;
            this.mainView.ShowPetView += ShowPetView;
        }

        private void ShowPetView(object? sender, EventArgs e)
        {
            IPetView view = new PetView();
            IPetRepository repository = new PetRepository(sqlConnection);
            new PetPresenter(view, repository);
        }
    }
}
