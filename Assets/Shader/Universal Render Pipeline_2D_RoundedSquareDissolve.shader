Shader "Universal Render Pipeline/2D/RoundedSquareDissolve" {
	Properties {
		_MainTex ("Diffuse", 2D) = "white" {}
		_MaskTex ("Mask", 2D) = "white" {}
		_NormalMap ("Normal Map", 2D) = "bump" {}
		_SquareSize ("Square Half Size (XZ)", Vector) = (2,2,0,0)
		_CornerRadius ("Corner Radius", Range(0, 10)) = 0.3
		_EdgeSoftness ("Edge Softness", Range(0, 0.5)) = 0.01
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_NoiseScale ("Noise Scale", Range(0.1, 10)) = 2
		_NoiseStrength ("Noise Strength", Range(0, 1)) = 0
		_NoiseSpeed ("Noise Animation Speed", Range(0, 5)) = 1
		_DissolveCenter ("Dissolve Center (World XZ)", Vector) = (0,0,0,0)
		[HideInInspector] _ZWrite ("ZWrite", Float) = 0
		[HideInInspector] _Color ("Tint", Vector) = (1,1,1,1)
		[HideInInspector] _RendererColor ("RendererColor", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaTex ("External Alpha", 2D) = "white" {}
		[HideInInspector] _EnableExternalAlpha ("Enable External Alpha", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
}