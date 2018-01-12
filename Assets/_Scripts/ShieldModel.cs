public class ShieldModel
{
    private int strength;
    public int RepairableThreshold { get; set; }
    public int RepairQuantity { get; set; }

    public ShieldModel()
    {
        this.strength = 100;
        this.RepairQuantity = 10;
        this.RepairableThreshold = 25;
    }

    public int GetStrength()
    {
        return this.strength;
    }

    public int GetRepairQuantity()
    {
        return this.RepairQuantity;
    }

    public int GetRepairableThreshold()
    {
        return this.RepairableThreshold;
    }

    // add to strength - but not go about 100
    public void AddStrength(int unitsToAdd)
    {
        this.strength += unitsToAdd;

        if (this.strength > 100)
        {
            this.strength = 100;
        }
    }

    // are shields below threshold allowing repair?
    public bool IsRepairable()
    {
        return (this.strength >= this.RepairableThreshold);
    }

    // if repariable, add RepairQuantity units each Tick()
    public void Tick()
    {
        if(this.strength < 100 && this.IsRepairable()){
            this.AddStrength(this.RepairQuantity);
        }
    }

    // reduce strength by given damage
    public bool TakeDamage(int damage)
    {
        // if damage would not take us below 0, then reduce strength
        if(damage <= this.strength){
            this.strength -= damage;
            return true;
        }

        // if got this far, failure ...
        return false;
    }
}
