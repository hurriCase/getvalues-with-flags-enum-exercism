using System;
using System.Collections.Generic;
using System.Linq;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = Eggs << 1,
    Shellfish = Peanuts << 1,
    Strawberries = Shellfish << 1,
    Tomatoes = Strawberries << 1,
    Chocolate = Tomatoes << 1,
    Pollen = Chocolate << 1,
    Cats = Pollen << 1
}

public class Allergies (int mask)
{
    private readonly Allergen _allergens = (Allergen)mask;
    public bool IsAllergicTo(Allergen allergen) =>
        _allergens.HasFlag(allergen);
 
    public Allergen[] List() => 
       Enum.GetValues<Allergen>()
        .Where(allergen => _allergens.HasFlag(allergen))
        .ToArray();
}