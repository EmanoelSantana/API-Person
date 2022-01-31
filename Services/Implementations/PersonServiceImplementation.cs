﻿using RestWithAspNet.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RestWithAspNet.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person create(Person person)
        {
            return person;
        }

        public void delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;  
        }

        public Person FindById(long id)
        {
            return new Person { Id = IncrementAndGet(), FirstName = "Emanoel", LastName = "Santana", Adress = "BA", Gender = "Male" };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person 
            { 
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Adress = "Person Adress" + i,
                Gender = "Person Gender" 
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
