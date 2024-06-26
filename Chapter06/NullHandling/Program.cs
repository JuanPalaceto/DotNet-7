﻿using NullHandling;

int thisCannotBeNull = 4;
//thisCannotBeNull = null; // compile error!
//WriteLine(thisCannotBeNull);

int? thisCouldBeNull = null;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

// the actual type of int? is Nullable<int>
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 9;
WriteLine(thisCouldAlsoBeNull);

Address address = new()
{
    Building = null,
    Street = null!,
    City = "London",
    Region = "UK"
};

WriteLine(address.Building?.Length);
WriteLine(address.Street.Length);

// check that the variable is not null before using it
//if (thisCouldBeNull != null)
//{
//    //access a member of thisCouldBeNull
//    int length = thisCouldBeNull.Length; // could throw an exception
//}