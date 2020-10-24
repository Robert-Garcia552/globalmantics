using Globalmantics.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globalmantics.Controllers
{
    public class ConferenceController: Controller
    {
        public ConferenceController(IConferenceService conferenceService)
        {

        }
    }
}
