namespace Final_Project2
{
    interface IDpsCharacter
    {
        // Organizes dps characters (They MUST have these methods.)
        // AttemptUpgrade MUST have an int
        bool AttemptUpgrade(int Something);
        void UpdateCost();
        void UpdateDamage();
    }
}
