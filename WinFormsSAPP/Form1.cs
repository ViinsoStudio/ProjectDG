using BusinessLogicSAPP.BL;
using DataAccessSAPP.Context;
using DataAccessSAPP.Queries;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Configuration;

namespace WinFormsSAPP
{
    public partial class InterfazSAPP : Form
    {
        private AnimalsBL _animalsBL;
        private AnimalsQueries _animalsQueriesBL;
        private AppDbContext _appDbContext;
        public InterfazSAPP()
        {
            InitializeComponent();
            ConfigureDbContext();
            AnimalTypes();
        }

        private void ConfigureDbContext()
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                optionsBuilder.UseSqlServer(connectionString);
                _appDbContext = new AppDbContext(optionsBuilder.Options);
                _animalsQueriesBL = new AnimalsQueries(_appDbContext);
                _animalsBL = new AnimalsBL(_animalsQueriesBL);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar el contexto de la base de datos: {ex.Message}");
            }
        }

        private void buttonRegistrarTipoAnimal_Click(object sender, EventArgs e)
        {
            var newAnimalType = textBoxTipoAnimal.Text;

            _animalsBL.CreateAnimalType(newAnimalType);
        }

        private void AnimalTypes()
        {
            comboBoxTiposDeAnimal.Text = "Seleccione un tipo de animal";
            var animalTypes = _animalsBL.GetAnimalTypes();
            foreach (var animalType in animalTypes)
            {
                comboBoxTiposDeAnimal.Items.Add(animalType.Nombre);
            }
        }

        private void buttonRegistrarRaza_Click(object sender, EventArgs e)
        {
            var animalType = comboBoxTiposDeAnimal.Text;
            var newRace = textBoxNuevaRaza.Text;

            _animalsBL.CreateRace(animalType, newRace);
        }
    }
}
