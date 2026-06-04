abstract class Character
{
    protected Character()
    {
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => "Character is a Character";
}

class Warrior : Character
{
    public Warrior() : base()
    {
    }

    public override string ToString() => "Character is a Warrior";

    public override int DamagePoints(Character target) => target.Vulnerable() == true ? 10 : 6;
}

class Wizard : Character
{
    private bool FeitiçoPronto = false;

        
    public Wizard() : base()
    {
    }

    public override string ToString() => "Character is a Wizard";

    public override int DamagePoints(Character target) => !FeitiçoPronto ? 3 : 12;

    public override bool Vulnerable() => !FeitiçoPronto ? true : false;
    
    public void PrepareSpell() => FeitiçoPronto = true;
}
