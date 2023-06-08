using Task_19.Model.Data;

namespace Task_19.Model.Interface
{
    public interface IFalseData
    {
        IEnumerable<PersonalData> GetFalsePersonalData();

        IEnumerable<Personalities> GetFalsePersonalities();
    }
}
