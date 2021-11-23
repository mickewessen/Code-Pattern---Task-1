using Code_Pattern___Task_1.Interfaces;

namespace Code_Pattern___Task_1.Interfaces
{
    public interface IAnimalExtraServices
    {
        public string NameOfService { get; set; }
        public decimal PriceOfService { get; set; }
        public IAnimal SelectedAnimal { get; set; }
    }
}