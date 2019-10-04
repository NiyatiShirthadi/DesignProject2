Shader "Unlit/DissolveW2B"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
		_SecondTex("SecondTexture", 2D) = "white" {}
		_DisolveTexture("Disolve Texture", 2D) = "white" {}
		_Blend("Blend Amount", Range(0,1)) = 1
	}
		SubShader
		{
			Tags { "RenderType" = "Opaque" }
			LOD 100

			Pass
			{
				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag

				#include "UnityCG.cginc"

				struct appdata
				{
					float4 vertex : POSITION;
					float2 uv : TEXCOORD0;
				};

				struct v2f
				{
					float2 uv : TEXCOORD0;
					float2 uv2 : TEXCOORD1;
					float4 vertex : SV_POSITION;
				};

				sampler2D _MainTex;
				sampler2D _SecondTex;
				float4 _MainTex_ST;
				float4 _SecondTex_ST;
				v2f vert(appdata v)
				{
					v2f o;
					o.vertex = UnityObjectToClipPos(v.vertex);
					o.uv = TRANSFORM_TEX(v.uv, _MainTex);
					o.uv2 = TRANSFORM_TEX(v.uv, _SecondTex);
					return o;
				}

				half _Blend;
				sampler2D _DisolveTexture;
				fixed4 frag(v2f i) : SV_Target
				{
					fixed4 texture1 = tex2D(_MainTex,i.uv);
					fixed4 texture2 = tex2D(_SecondTex,i.uv);
					return lerp(texture1,texture2,saturate(sign(_Blend - tex2D(_DisolveTexture,i.uv).r)));
				}
				ENDCG
			}
		}
}