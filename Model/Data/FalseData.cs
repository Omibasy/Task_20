using Task_19.Model.Interface;

namespace Task_19.Model.Data
{
    public class FalseData : IFalseData
    {
        private List<PersonalData> personalDatas;
        private List<Personalities> personalities;

        public FalseData()
        {
            personalDatas = new List<PersonalData>();
            personalities = new List<Personalities>();
            BuildFalsePersonalities();
            BuildFalsePersonalData();
        }

        public IEnumerable<PersonalData> GetFalsePersonalData()
        {
            return personalDatas;
        }

        public IEnumerable<Personalities> GetFalsePersonalities()
        {
            return personalities;
        }

        private void BuildFalsePersonalities()
        {
            personalities.Add(new Personalities()
            {
                ID = 1,
                Name = "Андрей",
                Surname = "Голубев",
                Patomic = "Сергеевич",
            });
            personalities.Add(new Personalities()
            {
                ID = 2,
                Name = "Кристина",
                Surname = "Боброва",
                Patomic = "Андреевна",
            });
            personalities.Add(new Personalities()
            {
                ID = 3,
                Name = "Татьяна",
                Surname = "Ершова",
                Patomic = "Павловна",
            });
            personalities.Add(new Personalities()
            {
                ID = 4,
                Name = "Юлия",
                Surname = "Михайлова",
                Patomic = "Артуровна",
            });
            personalities.Add(new Personalities()
            {
                ID = 5,
                Name = "Владимир",
                Surname = "Маслов",
                Patomic = "Маркович",
            });
            personalities.Add(new Personalities()
            {
                ID = 6,
                Name = "Константин",
                Surname = "Максимов",
                Patomic = "Сергеевич",
            });
            personalities.Add(new Personalities()
            {
                ID = 7,
                Name = "Иван",
                Surname = "Соловьёв",
                Patomic = "Романович",
            });
            personalities.Add(new Personalities()
            {
                ID = 8,
                Name = "Сергей",
                Surname = "Ильин",
                Patomic = "Иванович",
            });
            personalities.Add(new Personalities()
            {
                ID = 9,
                Name = "Валерий",
                Surname = "Матвеев",
                Patomic = "Александрович",
            });
            personalities.Add(new Personalities()
            {
                ID = 10,
                Name = "Сергей",
                Surname = "Абрамов",
                Patomic = "Сергеевич",
            });
            personalities.Add(new Personalities()
            {
                ID = 11,
                Name = "Ирина",
                Surname = "Андреева",
                Patomic = "Давидовна",
            });
            personalities.Add(new Personalities()
            {
                ID = 12,
                Name = "Дмитрий",
                Surname = "Гаврилов",
                Patomic = "Маркович",
            });



        }

        private void BuildFalsePersonalData()
        {
            personalDatas.Add(new PersonalData()
            {
                ID = 1,
                ID_Personalitie = 1,
                PhoneNumber = GetPhoneNumber(1),
                Address = "Новосибирская область, город Ступино, пл. Балканская,19",
                Description = GetText(),
                PersonalitiesID = personalities[0]
            }) ;
            personalDatas.Add(new PersonalData()
            {
                ID = 2,
                ID_Personalitie = 2,
                PhoneNumber = GetPhoneNumber(2),
                Address = "Калининградская область, город Серебряные Пруды, проезд Ленина, 82",
                Description = GetText(),
                PersonalitiesID = personalities[1]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 3,
                ID_Personalitie = 3,
                PhoneNumber = GetPhoneNumber(3),
                Address = "Новгородская область, город Ступино, бульвар Ладыгина, 98",
                Description = GetText(),
                PersonalitiesID = personalities[2]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 4,
                ID_Personalitie = 4,
                PhoneNumber = GetPhoneNumber(4),
                Address = "Кировская область, город Павловский Посад, спуск Славы, 60",
                Description = GetText(),
                PersonalitiesID = personalities[3],
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 5,
                ID_Personalitie = 5,
                PhoneNumber = GetPhoneNumber(5),
                Address = "Мурманская область, город Егорьевск, пл. Гагарина, 35",
                Description = GetText(),
                PersonalitiesID = personalities[4]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 6,
                ID_Personalitie = 6,
                PhoneNumber = GetPhoneNumber(6),
                Address = "Тамбовская область, город Шатура, пр. Бухарестская, 12",
                Description = GetText(),
                PersonalitiesID = personalities[5]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 7,
                ID_Personalitie = 7,
                PhoneNumber = GetPhoneNumber(7),
                Address = "Липецкая область, город Ногинск, наб. Гоголя, 70",
                Description = GetText(),
                PersonalitiesID = personalities[6]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 8,
                ID_Personalitie = 8,
                PhoneNumber = GetPhoneNumber(8),
                Address = "Новгородская область, город Шаховская, пл. Ломоносова, 88",
                Description = GetText(),
                PersonalitiesID = personalities[7]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 9,
                ID_Personalitie = 9,
                PhoneNumber = GetPhoneNumber(9),
                Address = "Новосибирская область, город Серпухов, пл. Ленина, 70",
                Description = GetText(),
                PersonalitiesID = personalities[8]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 10,
                ID_Personalitie = 10,
                PhoneNumber = GetPhoneNumber(10),
                Address = "Костромская область, город Подольск, ул. Домодедовская, 71",
                Description = GetText(),
                PersonalitiesID = personalities[9]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 11,
                ID_Personalitie = 11,
                PhoneNumber = GetPhoneNumber(11),
                Address = "Челябинская область, город Павловский Посад, пр. Гоголя, 59",
                Description = GetText(),
                PersonalitiesID = personalities[10]
            });
            personalDatas.Add(new PersonalData()
            {
                ID = 12,
                ID_Personalitie = 12,
                PhoneNumber = GetPhoneNumber(12),
                Address = "Омская область, город Красногорск, пер. 1905 года, 27",
                Description = GetText(),
                PersonalitiesID = personalities[11]
            });

        }

        private string GetText()
        {
            return " Lorem ipsum dolor sit amet consectetur, adipisicing elit. Molestias ducimus dignissimos optio,\r\ndolores cupiditate culpa eveniet placeat nihil, deleniti ab dicta? Illum et at possimus aliquid";
        }

        private string GetPhoneNumber(int id)
        {
            if (id > 9)
            { 
                Random random = new Random();
                id = random.Next(0,9);
         
            }

            return $"8-{id}{id}{id}-{id}{id}{id}-{id}{id}-{id}{id}";
        
        }


    }
}
