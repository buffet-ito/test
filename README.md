しきい値変更シェーダ?
====

テクスチャのアルファ値を元に描画ピクセルをコントロールします。

## Description
Unityのビルトインシェーダ「Sprites-Default」を一部変更して作成しました。

### Source

```shader:TestShader2.shader
			fixed4 frag(v2f IN) : SV_Target
			{
				fixed4 c = tex2D(_MainTex, IN.texcoord) * IN.color;
				float alpha = 1 - step(c.a, _threshold);
				c.rgb = IN.color.rgb * alpha;
				c.a = alpha;
				return c;
			}
```

## Demo
![sc](http://29jun2012-180156-6.businesscatalyst.com/unity/unity009/test2.gif)

