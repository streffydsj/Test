using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;

namespace Util.Validations
{
    public class Validation:IValidation
    {

        /// <summary>
        /// 初始化验证操作
        /// </summary>
        public Validation()
        {
            _result = new ValidationResultCollection();
        }

        /// <summary>
        /// 验证目标
        /// </summary>
        private object _target;
        /// <summary>
        /// 结果
        /// </summary>
        private readonly ValidationResultCollection _result;

        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="target">验证目标</param>
        public ValidationResultCollection Validate(object target)
        {
            
            
        }


    }
}
