namespace UNIR.TFE.Polyrepo.Division.Module.Application
{
    public class DivisionAppService : IDivisionAppService
    {
        public string Key => "div";

        public decimal Execute(decimal a, decimal b) => a / b;
    }
}
