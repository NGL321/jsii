using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    [JsiiClass(nativeType: typeof(OptionalStructConsumer), fullyQualifiedName: "jsii-calc.OptionalStructConsumer", parametersJson: "[{\"name\":\"optionalStruct\",\"optional\":true,\"type\":{\"fqn\":\"jsii-calc.OptionalStruct\"}}]")]
    public class OptionalStructConsumer : DeputyBase
    {
        public OptionalStructConsumer(Amazon.JSII.Tests.CalculatorNamespace.IOptionalStruct optionalStruct): base(new DeputyProps(new object[]{optionalStruct}))
        {
        }

        protected OptionalStructConsumer(ByRefValue reference): base(reference)
        {
        }

        protected OptionalStructConsumer(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "parameterWasUndefined", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ParameterWasUndefined
        {
            get => GetInstanceProperty<bool>();
        }

        [JsiiProperty(name: "fieldValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string FieldValue
        {
            get => GetInstanceProperty<string>();
        }
    }
}
