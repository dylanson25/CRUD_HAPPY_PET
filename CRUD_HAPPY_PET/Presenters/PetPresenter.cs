using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_HAPPY_PET.Models;
using CRUD_HAPPY_PET.Views;

namespace CRUD_HAPPY_PET.Presenters
{
    internal class PetPresenter
    {
        #region Fields
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petBindingSource;
        private IEnumerable<Pet> petList;

        #endregion

        #region Constructor
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Suscribe event handler methods to view events
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancerAction;

            //Set pets binding source
            this.view.SetPetListBindingSource(petBindingSource);

            //Load pet list view
            LoadAllPetList();

            //Show view
            this.view.Show();
        }
        #endregion

        #region Methods
        private void LoadAllPetList()
        {
            petList = repository.GotAll();
            petBindingSource.DataSource = petList;
        }

        private void CancerAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedPetToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPet(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                petList = repository.GotByValue(this.view.SearchValue);
            else petList = repository.GotAll();
            petBindingSource.DataSource = petList;
        }
        #endregion
    }
}
