using CallWebService.Libray.DataBeans;
using CallWebService.Libray.DataBeans.Template.Request;
using CallWebService.Libray.DataBeans.Template.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallWebService.Libray.Service.Template
{
    public interface ITemplateService
    {

        ReturnModel<List<BikeAvailabilityRespBean>> GetBikeAvailabilityData(UserReqBean user);
    }
}
