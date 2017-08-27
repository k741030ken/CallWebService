
using CallWebService.Libray.Service.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CallWebService.Libray.Service
{
    public class CallWebServiceFactory
    {
        #region "Local"
        /// <summary>
        /// 提供TemplateService
        /// </summary>
        private TemplateService _templateService = new TemplateService();

        #endregion "Local"

        #region "Constructor"

        private static CallWebServiceFactory _instance;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private CallWebServiceFactory()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static CallWebServiceFactory Instance()
        {
            if (_instance == null)
            {
                _instance = new CallWebServiceFactory();
            }
            return _instance;
        }

        #endregion "Constructor"

        #region "Property"
        /// <summary>
        /// 取得目前的ItemService
        /// </summary>
        public ITemplateService TemplateService
        {
            get
            {
                return _templateService;
            }
        }

        #endregion
    }
}
