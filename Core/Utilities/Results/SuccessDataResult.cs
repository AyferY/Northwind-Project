﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string messsage):base(data,true,messsage) 
        {
                
        }
        public SuccessDataResult(T data): base(data,true) 
        {

        }
        public SuccessDataResult(string message):base(default,true,message) 
        {
                
        }
        public SuccessDataResult():base(default,true) 
        {

        }
    }
}
