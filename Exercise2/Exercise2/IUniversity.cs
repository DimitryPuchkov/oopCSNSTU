using System;
using System.Collections.Generic;

namespace Exercise2
{
	interface IUniversity
	{
		IEnumerable<IPerson> Persons { get; }
		IEnumerable<Student> Students { get; }
		void Add(IPerson person);
		void Remove(IPerson person);
		IEnumerable<IPerson> FindByLastName(string lastName);
	}
}
