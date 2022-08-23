using System;


namespace CodeBlockFit.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthData { get; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// РОст.
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Создание пользователя.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthData">Дата рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="height">РОст</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, 
                    Gender gender, 
                    DateTime birthData, 
                    double weight, 
                    double height)
        {
            #region Проверка значений
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователяне может быть пустым", nameof(name));
            }


            if(Gender == null)
            {
                throw new ArgumentNullException("Пол должен быть заполнен", nameof(gender));
            }

            if(birthData < DateTime.Parse("01.01.1950") || birthData >= DateTime.Now)
            {
                throw new ArgumentException("Проверьте дату", nameof(birthData));
            }

            if (weight < 10)
            {
                throw new ArgumentException("Вес не может быть ниже", nameof(weight));
            }

            if (height < 70)
            {
                throw new ArgumentException("Рост не может быть ниже", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;                
            Height = height;
            BirthData = birthData;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
