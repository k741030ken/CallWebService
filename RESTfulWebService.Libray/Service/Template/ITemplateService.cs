using RESTfulWebService.Libray.DataBeans;
using RESTfulWebService.Libray.DataBeans.Template.Request;
using RESTfulWebService.Libray.DataBeans.Template.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulWebService.Libray.Service.Template
{
    public interface ITemplateService
    {

        ReturnModel<List<BikeAvailabilityRespBean>> GetBikeAvailabilityData(UserReqBean user);
    }
}
