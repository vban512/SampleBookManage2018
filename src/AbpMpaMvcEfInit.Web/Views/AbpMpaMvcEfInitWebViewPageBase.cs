using Abp.Web.Mvc.Views;

namespace AbpMpaMvcEfInit.Web.Views
{
    public abstract class AbpMpaMvcEfInitWebViewPageBase : AbpMpaMvcEfInitWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpMpaMvcEfInitWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpMpaMvcEfInitWebViewPageBase()
        {
            LocalizationSourceName = AbpMpaMvcEfInitConsts.LocalizationSourceName;
        }
    }
}