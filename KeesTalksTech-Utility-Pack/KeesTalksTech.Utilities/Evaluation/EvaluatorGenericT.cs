﻿namespace KeesTalksTech.Utilities.Evaluation
{
	using KeesTalksTech.Utilities.Compilation;

	/// <summary>
	/// Evaluator that will generate sripts with a certain base type.
	/// </summary>
	/// <typeparam name="BaseType">The base type of the classes that will be generated by the evaluator.</typeparam>
	/// <seealso cref="KeesTalksTech.Utilities.Evaluation.Evaluator" />
	public class Evaluator<BaseType> : Evaluator where BaseType : class, IProducer
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Evaluator{BaseType}"/> class.
		/// </summary>
		/// <param name="compiler">The compiler.</param>
		public Evaluator(ICompiler compiler) : base(compiler, typeof(BaseType))
		{
		}

		/// <summary>
		/// Creates the producer.
		/// </summary>
		/// <param name="code">The code.</param>
		/// <returns>The producer.</returns>
		public new BaseType CreateProducer(string code)
		{
			return (BaseType)base.CreateProducer(code);
		}
	}
}
