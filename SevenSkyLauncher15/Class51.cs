using System;
using System.Linq.Expressions;

// Token: 0x020000CA RID: 202
internal class Class51 : ExpressionVisitor
{
	// Token: 0x06000681 RID: 1665 RVA: 0x000072C3 File Offset: 0x000054C3
	protected override Expression VisitConditional(ConditionalExpression node)
	{
		if (node.IfFalse.NodeType == ExpressionType.Throw)
		{
			return Expression.Condition(node.Test, node.IfTrue, Expression.Constant(Class51.object_0));
		}
		return base.VisitConditional(node);
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000072F7 File Offset: 0x000054F7
	public Class51()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00007304 File Offset: 0x00005504
	// Note: this type is marked as 'beforefieldinit'.
	static Class51()
	{
		Class202.ofdixO4zTbIfy();
		Class51.object_0 = new object();
	}

	// Token: 0x04000420 RID: 1056
	internal static readonly object object_0;
}
