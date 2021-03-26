using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity) /*men bura entity,dto her sey artira bilerem hamsinin da basei objectdir*/
        {
            var context = new ValidationContext<object>(entity);
            /*ProductValidator productValidator = new ProductValidator(); burada bu setri silirik niye ProductManagerde productVlidatora f12 basanda goruruk ki bunun interfeysi IValidatordur.Interfeysler de referans tutucu olduqlari ucun menim ProductValidatorumun referansini saxliyir ve bizim bu setri saxlamagimiza ehtiyac qalmir */ 
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
