public class M
{
    public string id_weight { get; set; }
    public string weight_name { get; set; }
    public string age_name { get; set; }
    public string gender { get; set; }
}

public class F
{
    public string id_weight { get; set; }
    public string weight_name { get; set; }
    public string age_name { get; set; }
    public string gender { get; set; }
}

public class Genders
{
    public List<M> m { get; set; }
    public List<F> f { get; set; }
}

public class GenderWeightCategories
{
    public Genders genders { get; set; }
}
