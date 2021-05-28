using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_Task_1
{
    class Actions
    {
        private readonly Logger _logger = Logger.Instance;
        public Result SomeMethod0()
        {
            _logger.LoggerEventInfo($"Start method: {nameof(SomeMethod0)}");
            return new Result() { Status = true };
        }
        public Result SomeMethod1()
        {
            _logger.LoggerEventWarning($"Skipped loggic in a method: {nameof(SomeMethod1)}");
            return new Result() { Status = true };
        }
        public Result SomeMethod2()
        {
            return new Result() { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
