using System;

namespace SecondTask
{
    /// <summary>
    /// Class represents Person
    /// </summary>
    public class Person
    {
        #region Properties
        /// <summary>
        /// Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Random object
        /// </summary>
        private Random Random { get; } = new Random();
        #endregion

        #region Constructors
        /// <summary>
        /// Sets initial field values
        /// </summary>
        public Person()
        {
            Age = Random.Next(1,101);
            Name = Random.Next('a','z').ToString();
            Id = Random.Next();
        }

        /// <summary>
        /// Sets initial field values
        /// </summary>
        /// <param name="age">Age</param>
        /// <param name="name">Name</param>
        /// <param name="id">Id</param>
        public Person(int age, string name, int id)
        {
            Age = age;
            Name = name;
            Id = id;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Compares two values
        /// </summary>
        /// <param name="obj">Compared value</param>
        /// <returns>Returns true, if values are the same and false if values are different</returns>
        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Age == person.Age &&
                   Name == person.Name &&
                   Id == person.Id;
        }

        /// <summary>
        /// Gets hash code of value
        /// </summary>
        /// <returns>Returns Hash Code of value</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Age, Name, Id);
        }
        #endregion
    }
}
