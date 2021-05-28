using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_Task_1
{
    public class Starter
    {
        private const string LoggerFileWay = "Log.txt";
        private readonly Logger _logger;
        private readonly Actions _actions;
        private readonly FileService _fileService;

        public Starter()
        {
            _logger = Logger.Instance;
            _actions = new Actions();
            _fileService = new FileService();
        }
        
        public void Run()
        {
            var random = new Random();
            for(var counter = 0; counter < 100; counter++)
            {
                var randomAction = random.Next(0, 3);
                var result = new Result();

                switch (randomAction)
                {
                    case 0:
                        result = _actions.SomeMethod0();
                        break;
                    case 1:
                        result = _actions.SomeMethod1();
                        break;
                    case 2:
                        result = _actions.SomeMethod2();
                        break;
                }

                if (!result.Status)
                {
                    _logger.LoggerEventError($"Actions failed by a reason: {result.ErrorMessage}");
                }
            }
            _fileService.Write(LoggerFileWay, _logger.Logs);
        }
    }
}
