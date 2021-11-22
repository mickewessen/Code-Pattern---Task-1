using Code_Pattern___Task_1.Interfaces;

namespace Code_Pattern___Task_1.Interfaces
{
    public interface IAnimalExtraServices
    {
        string NameOfService { get; set; }
        decimal PriceOfService { get; set; }
        IReciept Reciept { get; set; }
        IAnimal SelectedAnimal { get; set; }
    }
}