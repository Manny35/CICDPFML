// ----------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a compiler emitter: FACTS.Framework.Analysis.Generators.OperationMethod.ControllerEmitter
//
// Changes to this file may cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------------------------------------

using System;
using Microsoft.AspNetCore.Mvc;
using FACTS.Framework.Service;

namespace PFML.Service.Controllers.Core.Headers
{

    public class PersonController : Controller
    {

        [HttpPost]
        [Route("Core/Headers/Person/BlankSearchCriteria")]
        [OperationMethodFilter]
        public PFML.Shared.ViewModels.Core.Headers.Person.SearchCriteria BlankSearchCriteria()
        {
            return PFML.BusinessLogic.Core.Headers.PersonLogic.BlankSearchCriteria();
        }

        [HttpPost]
        [Route("Core/Headers/Person/Search")]
        [OperationMethodFilter]
        public System.Collections.Generic.List<PFML.Shared.ViewModels.Core.Headers.Person.ResultRecord> Search([FromBody]PFML.Shared.ViewModels.Core.Headers.Person.SearchCriteria criteria)
        {
            return PFML.BusinessLogic.Core.Headers.PersonLogic.Search(criteria);
        }

        [HttpPost]
        [Route("Core/Headers/Person/Fetch")]
        [OperationMethodFilter]
        public PFML.Shared.ViewModels.Core.Headers.Person.Record Fetch([FromBody]int id)
        {
            return PFML.BusinessLogic.Core.Headers.PersonLogic.Fetch(id);
        }

    }

}
