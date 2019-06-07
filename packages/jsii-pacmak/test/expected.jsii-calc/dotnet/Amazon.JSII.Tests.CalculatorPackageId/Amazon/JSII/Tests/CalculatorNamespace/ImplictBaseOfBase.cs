using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    [JsiiByValue]
    public class ImplictBaseOfBase : IImplictBaseOfBase
    {
        [JsiiProperty(name: "goo", typeJson: "{\"primitive\":\"date\"}", isOverride: true)]
        public System.DateTime Goo
        {
            get;
            set;
        }

        [JsiiProperty(name: "bar", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Bar
        {
            get;
            set;
        }

        [JsiiProperty(name: "foo", typeJson: "{\"fqn\":\"@scope/jsii-calc-base-of-base.Very\"}", isOverride: true)]
        public Amazon.JSII.Tests.CalculatorNamespace.BaseOfBaseNamespace.Very Foo
        {
            get;
            set;
        }
    }
}
