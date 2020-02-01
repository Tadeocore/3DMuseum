Shader "Custom/WorldDiscoverSHader"
{
 Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness("Smoothness", Range(0,1)) = 0.5
		_Metallic("Metallic", Range(0,1)) = 0.0
 
		_DissolveTexture("Dissolve texture", 2D) = "white" {}
		_Radius("Distance", Float) = 1 //distance where we start to reveal the objects
	}
		SubShader{
			Tags { "RenderType" = "Opaque" }
			LOD 200
			Cull off //material is two sided
 
		CGPROGRAM
 
		#pragma surface surf Standard fullforwardshadows
 
		#pragma target 3.0
 
		sampler2D _MainTex;
		sampler2D _DissolveTexture; //texture where we get the dissolve value
 
		struct Input
		{
			float2 uv_MainTex;
			float3 worldPos; //Built-in world position
		};
 
		half _Glossiness;
		half _Metallic;
		fixed4 _Color;
 
		float3 _PlayerPos; //"Global Shader Variable", contains the Player Position
		float _Radius; 
 
		void surf (Input IN, inout SurfaceOutputStandard o) {
 
			half dissolve_value = tex2D(_DissolveTexture, IN.uv_MainTex).x;
 
			float dist = distance(_PlayerPos, IN.worldPos);
 
			clip(dissolve_value - dist/ _Radius);
 
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;
		}
 
		ENDCG
	}
	FallBack "Diffuse"
}
 