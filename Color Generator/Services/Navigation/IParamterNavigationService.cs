
namespace Color_Generator.Services
{
    public interface IParamterNavigationService<TParameter>
    {
        void Navigate(TParameter parameter);
    }
}
