
using RESTfulWebService.Libray.Service.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulWebService.Libray.Service
{
    public class RESTfulWebServiceFactory
    {
        #region "Local"
        /// <summary>
        /// 提供TemplateService
        /// </summary>
        private TemplateService _templateService = new TemplateService();

        #endregion "Local"

        #region "Constructor"

        private static RESTfulWebServiceFactory _instance;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private RESTfulWebServiceFactory()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static RESTfulWebServiceFactory Instance()
        {
            if (_instance == null)
            {
                _instance = new RESTfulWebServiceFactory();
            }
            return _instance;
        }

        #endregion "Constructor"

        #region "Property"
        /// <summary>
        /// 取得目前的ItemService
        /// </summary>
        public ITemplateService templateService
        {
            get
            {
                return _templateService;
            }
        }

        #endregion
    }
}
