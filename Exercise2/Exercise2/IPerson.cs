using System;

namespace Exercise2
{
	interface IPerson
	{
		string Name { get; }
		string Patronomic { get; }
		string Lastname { get; }
		DateTime Date { get; }
		int Age { get; }
	}
}
