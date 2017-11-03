using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Sex { get; set; }


    }
    //表达式解析
    public class AnalysisExpression
    {
        public static void VisitExpression(Expression expression)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.Call://执行方法
                    MethodCallExpression method = expression as MethodCallExpression;
                    Console.WriteLine("方法名:" + method.Method.Name);
                    for (int i = 0; i < method.Arguments.Count; i++)
                        VisitExpression(method.Arguments[i]);
                    break;
                case ExpressionType.Lambda://lambda表达式
                    LambdaExpression lambda = expression as LambdaExpression;
                    VisitExpression(lambda.Body);
                    break;
                case ExpressionType.Equal://相等比较
                case ExpressionType.AndAlso://and条件运算
                    BinaryExpression binary = expression as BinaryExpression;
                    Console.WriteLine("运算符:" + expression.NodeType.ToString());
                    VisitExpression(binary.Left);
                    VisitExpression(binary.Right);
                    break;
                case ExpressionType.Constant://常量值
                    ConstantExpression constant = expression as ConstantExpression;
                    Console.WriteLine("常量值:" + constant.Value.ToString());
                    break;
                case ExpressionType.MemberAccess:
                    MemberExpression Member = expression as MemberExpression;
                    Console.WriteLine("字段名称:{0}，类型:{1}", Member.Member.Name, Member.Type.ToString());
                    break;
                default:
                    Console.Write("UnKnow");
                    break;
            }
        }

    }

    public class Main
    {
        Expression<Func<Student, bool>> expression = t => t.Name == "农码一生" && t.Sex == "男";
        public void MainMethod()
        {
            AnalysisExpression.VisitExpression(expression);
        }
    }
}
