#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename T1>
struct VirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3>
struct VirtualActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Action`1<System.Int32>
struct Action_1_tD69A6DC9FBE94131E52F5A73B2A9D4AB51EEC404;
// System.Action`2<System.Int32,System.Int32>
struct Action_2_tD7438462601D3939500ED67463331FE00CFFBDB8;
// System.Collections.Generic.List`1<UnityEngine.CanvasGroup>
struct List_1_t2CDCA768E7F493F5EDEBC75AEB200FD621354E35;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_tB951CE80B58D1BF9650862451D8DAD8C231F207B;
// System.Collections.Generic.List`1<UnityEngine.UI.Image>
struct List_1_tE6BB71ABF15905EFA2BE92C38A2716547AEADB19;
// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween>
struct TweenRunner_1_t5BB0582F926E75E2FE795492679A6CF55A4B4BC4;
// UnityEngine.UI.Image[]
struct ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// UnityEngine.UI.Selectable[]
struct SelectableU5BU5D_t4160E135F02A40F75A63F787D36F31FEC6FE91A9;
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// UnityEngine.UIVertex[]
struct UIVertexU5BU5D_tBC532486B45D071A520751A90E819C77BA4E3D2F;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
// Ricimi.AnimatedButton
struct AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E;
// UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354;
// UnityEngine.UI.AnimationTriggers
struct AnimationTriggers_tA0DC06F89C5280C6DD972F6F4C8A56D7F4F79074;
// UnityEngine.Animator
struct Animator_t8A52E42AE54F76681838FE9E632683EF3952E883;
// UnityEngine.AudioSource
struct AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299;
// Ricimi.BackgroundMusic
struct BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD;
// UnityEngine.EventSystems.BaseRaycaster
struct BaseRaycaster_t7DC8158FD3CA0193455344379DD5FF7CD5F1F832;
// UnityEngine.Camera
struct Camera_tA92CC927D7439999BC82DBEDC0AA45B470F9E184;
// UnityEngine.Canvas
struct Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26;
// UnityEngine.CanvasGroup
struct CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094;
// UnityEngine.CanvasRenderer
struct CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860;
// Ricimi.ColorSwapper
struct ColorSwapper_t5F1C217CDAE4B913B63FBEADD2AC2D6D27F4171A;
// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3;
// UnityEngine.Coroutine
struct Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B;
// UnityEngine.EventSystems.EventSystem
struct EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707;
// Ricimi.Fader
struct Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF;
// UnityEngine.UI.FontData
struct FontData_tB8E562846C6CB59C43260F69AE346B9BF3157224;
// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F;
// UnityEngine.UI.Graphic
struct Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.Collections.IEnumerator
struct IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA;
// UnityEngine.UI.Image
struct Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E;
// Ricimi.InitialPlayerPrefs
struct InitialPlayerPrefs_tFB58CC4998B1CC4D458FD13F089ED23F01C784EA;
// UnityEngine.Events.InvokableCallList
struct InvokableCallList_t309E1C8C7CE885A0D2F98C84CEA77A8935688382;
// Ricimi.LevelScene
struct LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073;
// UnityEngine.Material
struct Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3;
// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71;
// Ricimi.MusicButton
struct MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467;
// Ricimi.MusicManager
struct MusicManager_t49777347B8E0DCB451520D9032E435E8533FC47E;
// Ricimi.MuteBackgroundMusic
struct MuteBackgroundMusic_tA2D83AF4D170E8E0B5B6CADC28C1F2390C2B9B04;
// System.NotSupportedException
struct NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A;
// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;
// UnityEngine.Events.PersistentCallGroup
struct PersistentCallGroup_tB826EDF15DC80F71BCBCD8E410FD959A04C33F25;
// Ricimi.PlayPopup
struct PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B;
// Ricimi.PlayPopupOpener
struct PlayPopupOpener_t5A94A3B51FE3D020DC0FEDC0B71C1ADA5080CBFE;
// UnityEngine.EventSystems.PointerEventData
struct PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB;
// Ricimi.Popup
struct Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8;
// Ricimi.PopupOpener
struct PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421;
// UnityEngine.UI.RectMask2D
struct RectMask2D_tACF92BE999C791A665BD1ADEABF5BCEB82846670;
// UnityEngine.RectTransform
struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// Ricimi.SceneTransition
struct SceneTransition_tCB626AD8A4C6B1DF87F1F55575D36D043C8C6A69;
// UnityEngine.UI.Selectable
struct Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712;
// UnityEngine.UI.Slider
struct Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F;
// Ricimi.SoundButton
struct SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554;
// Ricimi.SoundManager
struct SoundManager_t11FAAFE4BA02BF7347C1BC24FCCF11EC1DE8A7E8;
// Ricimi.SpinWheel
struct SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225;
// UnityEngine.Sprite
struct Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99;
// Ricimi.SpriteSwapper
struct SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8;
// System.String
struct String_t;
// UnityEngine.UI.Text
struct Text_tD60B2346DAA6666BF0D822FF607F0B220C2B9E62;
// UnityEngine.TextGenerator
struct TextGenerator_t85D00417640A53953556C01F9D4E7DDE1ABD8FEC;
// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700;
// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4;
// Ricimi.TintedButton
struct TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74;
// Touch
struct Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// Ricimi.Transition
struct Transition_tD3D7356191E3387D36D7B57C22E5021280E80951;
// UnityEngine.EventSystems.UIBehaviour
struct UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D;
// UnityEngine.Events.UnityAction
struct UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7;
// UnityEngine.Events.UnityEvent
struct UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977;
// UnityEngine.UI.VertexHelper
struct VertexHelper_tB905FCB02AE67CBEE5F265FE37A5938FC5D136FE;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// UnityEngine.WaitForEndOfFrame
struct WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3;
// Ricimi.AnimatedButton/ButtonClickedEvent
struct ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8;
// Ricimi.BackgroundMusic/<FadeAudio>d__6
struct U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB;
// UnityEngine.Canvas/WillRenderCanvases
struct WillRenderCanvases_tA4A6E66DBA797DCB45B995DBA449A9D1D80D0FBC;
// Ricimi.Fader/<RunFadeIn>d__5
struct U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A;
// Ricimi.Fader/<RunFadeOut>d__6
struct U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039;
// UnityEngine.UI.MaskableGraphic/CullStateChangedEvent
struct CullStateChangedEvent_t6073CD0D951EC1256BF74B8F9107D68FC89B99B8;
// Ricimi.Popup/<RunPopupDestroy>d__4
struct U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B;
// UnityEngine.RectTransform/ReapplyDrivenProperties
struct ReapplyDrivenProperties_t3482EA130A01FF7EE2EEFE37F66A5215D08CFE24;
// UnityEngine.UI.Slider/SliderEvent
struct SliderEvent_t92A82EF6C62E15AF92B640FE2D960E877E8C6555;
// Ricimi.SpinWheel/<DoSpin>d__3
struct U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02;
// Ricimi.TintedButton/<BrightenColor>d__17
struct U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B;
// Ricimi.TintedButton/<DarkenColor>d__16
struct U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A;
// Ricimi.TintedButton/ButtonClickedEvent
struct ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E;
// Ricimi.Transition/<RunFade>d__5
struct U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D;

IL2CPP_EXTERN_C RuntimeClass* BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E;
IL2CPP_EXTERN_C String_t* _stringLiteral010CF79B276B799D3075D15F60FEA1F42DE0231C;
IL2CPP_EXTERN_C String_t* _stringLiteral058B00E75A4248FD43D00FBBE466461FE0E26422;
IL2CPP_EXTERN_C String_t* _stringLiteral0766E12DBBF735D07383A0BD874E9832C568F7C8;
IL2CPP_EXTERN_C String_t* _stringLiteral234D19ACC97DBDDB4C2351D9B583DDC8AD958380;
IL2CPP_EXTERN_C String_t* _stringLiteral461E3E44AE80BC4E861DB32ED3691F004543C3A2;
IL2CPP_EXTERN_C String_t* _stringLiteral48419E0AC7A3C471E758A3F53E24363D7898657B;
IL2CPP_EXTERN_C String_t* _stringLiteral4C07E7B7967064E6CE8D573509183B7F8A0A42C2;
IL2CPP_EXTERN_C String_t* _stringLiteral4D5F60EE1CF72404BFE4275C2F2246B6496A2207;
IL2CPP_EXTERN_C String_t* _stringLiteral508A0D658A13F703F966F8F692AC070E724F5C92;
IL2CPP_EXTERN_C String_t* _stringLiteral5D48754EEDD124010E593542F383BB714807301A;
IL2CPP_EXTERN_C String_t* _stringLiteral5FCDDC1467FCECED756A40E50069F3AB7F63BFB4;
IL2CPP_EXTERN_C String_t* _stringLiteral63D0716BC6E71CF8171A831003482E728DFDD739;
IL2CPP_EXTERN_C String_t* _stringLiteral6C858B704FEF0D525710D559CD932694EF007F75;
IL2CPP_EXTERN_C String_t* _stringLiteral6CE02DBF10772951A436ED08602B6C21AF7A06F2;
IL2CPP_EXTERN_C String_t* _stringLiteral764C47C904EA835A2474591FF7FEA8354BBD2829;
IL2CPP_EXTERN_C String_t* _stringLiteral78ED5F064518257EE2A43CDF95BFC6D9694BEC47;
IL2CPP_EXTERN_C String_t* _stringLiteral7AEFF743A4AF3DCC8C577977567121A4C1CD3BCE;
IL2CPP_EXTERN_C String_t* _stringLiteral89C5316A8C5B56F49BBC3872ADAA752D43808D2F;
IL2CPP_EXTERN_C String_t* _stringLiteral8DFA5A8CC04AC53F0ACE396F9570B4A33CD4F7FA;
IL2CPP_EXTERN_C String_t* _stringLiteralA68C68B0226E4226FF92C67906FD8F4309260CF1;
IL2CPP_EXTERN_C String_t* _stringLiteralB4682038889D880775C9BFAA4A7B79D3F99829CC;
IL2CPP_EXTERN_C String_t* _stringLiteralCA24A9346B673E2A6B3B521D7CAE3C735390E49B;
IL2CPP_EXTERN_C String_t* _stringLiteralCD444BB2FB0B21493A7D6581BF6B7AFC93A5C552;
IL2CPP_EXTERN_C String_t* _stringLiteralE383D87043E9C13D6699C11A033A799887F9CB9F;
IL2CPP_EXTERN_C String_t* _stringLiteralE52EB343FFBB01D406760FC6F6DABBD77D302C08;
IL2CPP_EXTERN_C String_t* _stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD;
IL2CPP_EXTERN_C String_t* _stringLiteralEDD87ED879AA06519D891F348976F2B64886115D;
IL2CPP_EXTERN_C String_t* _stringLiteralEE1FCAC446340AFD25CB10F3EE5EB58C946BBCF0;
IL2CPP_EXTERN_C String_t* _stringLiteralF30B1954717235507FA88FE3CCF0EDAA57C6BDC5;
IL2CPP_EXTERN_C String_t* _stringLiteralF349388D8BE15C1163C52DD0658C0609DE349B15;
IL2CPP_EXTERN_C String_t* _stringLiteralFC075BC3DFE942623230E78DC9D41126E9C003CA;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_m1C9FCB4BBE56BEC6BDEF6E4BA1E5DFF91614D7CE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m42DA4DEA19EB60D80CBED7413ADEB27FA033C77B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisCanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094_mA3B0428368982ED39ADEBB220EE67D1E99D8B2D2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mE74EE63C85A63FC34DCFC631BC229207B420BC79_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisSlider_t87EA570E3D6556CABF57456C2F3873FFD86E652F_mCE53A354B934E9BDB2E8D3094F4E33EBA8FFAFBA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisSpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8_m2100FD891B70F2F1919338CF4A2452B5E85F5A0B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_m755CF1DB6A65043AC21E6F3153B9060B358DCC64_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_AddComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_m13C85FD585C0679530F8B35D0B39D965702FD0F5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_AddComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA327C9E1CA12BC531D587E7567F2067B96E6B6A0_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_AddComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_mD73B7D6B9F588A50174DF721AF3EDEA2B35A0121_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_mB84A0931B2081CCADE7C5D459B2A8FAA6D3D3BD3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m4F30DAB8E5B57E8DB6BD8C0C3BB11CCB57690C4A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisBackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_m4B9C60B03C34C49C717FA17E9D4DBE7F8625C163_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_mE5A2711FA84F57F5EA0876DB106B1A146956CEFE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA59EA7D5F9133B2593F4AB70B099928BA955EE7D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisMusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467_m96FF2F4E6BDD0A9AADEE7E112EB966D9DC016DBD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisPlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B_m9955D8B5067AA7DBEBD6120D0AFA6D09DAFDA63B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisPopup_tC1E66E522EA4DBB41FC326155A497B0D820337F8_m9E3A528EE1D81D2B08C1650C99FFE3D108BD89B9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisSoundButton_t3E516F24DF47C4E25F3870D7687C058064176554_mA298D7DA24E33499C8038ADD34ED3BC16E96B090_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_m064CAE44C544384024AE4043702D2BEC084DF9EC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m10D87C6E0708CA912BBB02555BF7D0FBC5D7A2B3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CBrightenColorU3Ed__17_System_Collections_IEnumerator_Reset_m04B6E0737535BAEF3ED1A55F292EEA88D0638499_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CDarkenColorU3Ed__16_System_Collections_IEnumerator_Reset_m43F480B241F3895CA58E9B51FE7A164010DAE939_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CDoSpinU3Ed__3_System_Collections_IEnumerator_Reset_mD314362705FD0647965F859DF9224330E37D9D23_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CFadeAudioU3Ed__6_System_Collections_IEnumerator_Reset_mC26FF5D3A3046339A396FF326BBB4556ED102C34_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CRunFadeInU3Ed__5_System_Collections_IEnumerator_Reset_m752BB6020A57F176139BC360D65032BCEA6324B6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CRunFadeOutU3Ed__6_System_Collections_IEnumerator_Reset_mCF19D9B85EFF5445A99D58C5113A316B09A3971B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CRunFadeU3Ed__5_System_Collections_IEnumerator_Reset_m6B71FF6A0F04C12F03B9B4F0CC01590E8922A422_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CRunPopupDestroyU3Ed__4_System_Collections_IEnumerator_Reset_m0A5A6719D2A873657BB745E628FF98748914EBB7_RuntimeMethod_var;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.EventSystems.AbstractEventData
struct AbstractEventData_tAE1A127ED657117548181D29FFE4B1B14D8E67F7  : public RuntimeObject
{
	// System.Boolean UnityEngine.EventSystems.AbstractEventData::m_Used
	bool ___m_Used_0;
};
struct Il2CppArrayBounds;

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// UnityEngine.Events.UnityEventBase
struct UnityEventBase_t4968A4C72559F35C0923E4BD9C042C3A842E1DB8  : public RuntimeObject
{
	// UnityEngine.Events.InvokableCallList UnityEngine.Events.UnityEventBase::m_Calls
	InvokableCallList_t309E1C8C7CE885A0D2F98C84CEA77A8935688382* ___m_Calls_0;
	// UnityEngine.Events.PersistentCallGroup UnityEngine.Events.UnityEventBase::m_PersistentCalls
	PersistentCallGroup_tB826EDF15DC80F71BCBCD8E410FD959A04C33F25* ___m_PersistentCalls_1;
	// System.Boolean UnityEngine.Events.UnityEventBase::m_CallsDirty
	bool ___m_CallsDirty_2;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// UnityEngine.YieldInstruction
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_com
{
};

// Ricimi.BackgroundMusic/<FadeAudio>d__6
struct U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB  : public RuntimeObject
{
	// System.Int32 Ricimi.BackgroundMusic/<FadeAudio>d__6::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Ricimi.BackgroundMusic/<FadeAudio>d__6::<>2__current
	RuntimeObject* ___U3CU3E2__current_1;
	// Ricimi.BackgroundMusic/Fade Ricimi.BackgroundMusic/<FadeAudio>d__6::fadeType
	int32_t ___fadeType_2;
	// System.Single Ricimi.BackgroundMusic/<FadeAudio>d__6::time
	float ___time_3;
	// Ricimi.BackgroundMusic Ricimi.BackgroundMusic/<FadeAudio>d__6::<>4__this
	BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* ___U3CU3E4__this_4;
	// System.Single Ricimi.BackgroundMusic/<FadeAudio>d__6::<start>5__2
	float ___U3CstartU3E5__2_5;
	// System.Single Ricimi.BackgroundMusic/<FadeAudio>d__6::<end>5__3
	float ___U3CendU3E5__3_6;
	// System.Single Ricimi.BackgroundMusic/<FadeAudio>d__6::<i>5__4
	float ___U3CiU3E5__4_7;
	// System.Single Ricimi.BackgroundMusic/<FadeAudio>d__6::<step>5__5
	float ___U3CstepU3E5__5_8;
};

// Ricimi.Fader/<RunFadeIn>d__5
struct U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A  : public RuntimeObject
{
	// System.Int32 Ricimi.Fader/<RunFadeIn>d__5::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Ricimi.Fader/<RunFadeIn>d__5::<>2__current
	RuntimeObject* ___U3CU3E2__current_1;
	// Ricimi.Fader Ricimi.Fader/<RunFadeIn>d__5::<>4__this
	Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* ___U3CU3E4__this_2;
	// System.Single Ricimi.Fader/<RunFadeIn>d__5::<time>5__2
	float ___U3CtimeU3E5__2_3;
	// System.Single Ricimi.Fader/<RunFadeIn>d__5::<initialAlpha>5__3
	float ___U3CinitialAlphaU3E5__3_4;
};

// Ricimi.Fader/<RunFadeOut>d__6
struct U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039  : public RuntimeObject
{
	// System.Int32 Ricimi.Fader/<RunFadeOut>d__6::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Ricimi.Fader/<RunFadeOut>d__6::<>2__current
	RuntimeObject* ___U3CU3E2__current_1;
	// Ricimi.Fader Ricimi.Fader/<RunFadeOut>d__6::<>4__this
	Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* ___U3CU3E4__this_2;
	// System.Single Ricimi.Fader/<RunFadeOut>d__6::<time>5__2
	float ___U3CtimeU3E5__2_3;
	// System.Single Ricimi.Fader/<RunFadeOut>d__6::<initialAlpha>5__3
	float ___U3CinitialAlphaU3E5__3_4;
};

// Ricimi.Popup/<RunPopupDestroy>d__4
struct U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B  : public RuntimeObject
{
	// System.Int32 Ricimi.Popup/<RunPopupDestroy>d__4::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Ricimi.Popup/<RunPopupDestroy>d__4::<>2__current
	RuntimeObject* ___U3CU3E2__current_1;
	// Ricimi.Popup Ricimi.Popup/<RunPopupDestroy>d__4::<>4__this
	Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* ___U3CU3E4__this_2;
};

// Ricimi.SpinWheel/<DoSpin>d__3
struct U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02  : public RuntimeObject
{
	// System.Int32 Ricimi.SpinWheel/<DoSpin>d__3::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Ricimi.SpinWheel/<DoSpin>d__3::<>2__current
	RuntimeObject* ___U3CU3E2__current_1;
	// Ricimi.SpinWheel Ricimi.SpinWheel/<DoSpin>d__3::<>4__this
	SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* ___U3CU3E4__this_2;
	// System.Single Ricimi.SpinWheel/<DoSpin>d__3::<timer>5__2
	float ___U3CtimerU3E5__2_3;
	// System.Single Ricimi.SpinWheel/<DoSpin>d__3::<startAngle>5__3
	float ___U3CstartAngleU3E5__3_4;
	// System.Single Ricimi.SpinWheel/<DoSpin>d__3::<time>5__4
	float ___U3CtimeU3E5__4_5;
	// System.Single Ricimi.SpinWheel/<DoSpin>d__3::<maxAngle>5__5
	float ___U3CmaxAngleU3E5__5_6;
};

// Ricimi.TintedButton/<BrightenColor>d__17
struct U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B  : public RuntimeObject
{
	// System.Int32 Ricimi.TintedButton/<BrightenColor>d__17::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Ricimi.TintedButton/<BrightenColor>d__17::<>2__current
	RuntimeObject* ___U3CU3E2__current_1;
	// UnityEngine.UI.Image Ricimi.TintedButton/<BrightenColor>d__17::image
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___image_2;
	// System.Int32 Ricimi.TintedButton/<BrightenColor>d__17::<i>5__2
	int32_t ___U3CiU3E5__2_3;
};

// Ricimi.TintedButton/<DarkenColor>d__16
struct U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A  : public RuntimeObject
{
	// System.Int32 Ricimi.TintedButton/<DarkenColor>d__16::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Ricimi.TintedButton/<DarkenColor>d__16::<>2__current
	RuntimeObject* ___U3CU3E2__current_1;
	// UnityEngine.UI.Image Ricimi.TintedButton/<DarkenColor>d__16::image
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___image_2;
	// System.Int32 Ricimi.TintedButton/<DarkenColor>d__16::<i>5__2
	int32_t ___U3CiU3E5__2_3;
};

// UnityEngine.AnimatorStateInfo
struct AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 
{
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Name
	int32_t ___m_Name_0;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Path
	int32_t ___m_Path_1;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_FullPath
	int32_t ___m_FullPath_2;
	// System.Single UnityEngine.AnimatorStateInfo::m_NormalizedTime
	float ___m_NormalizedTime_3;
	// System.Single UnityEngine.AnimatorStateInfo::m_Length
	float ___m_Length_4;
	// System.Single UnityEngine.AnimatorStateInfo::m_Speed
	float ___m_Speed_5;
	// System.Single UnityEngine.AnimatorStateInfo::m_SpeedMultiplier
	float ___m_SpeedMultiplier_6;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Tag
	int32_t ___m_Tag_7;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Loop
	int32_t ___m_Loop_8;
};

// UnityEngine.EventSystems.BaseEventData
struct BaseEventData_tE03A848325C0AE8E76C6CA15FD86395EBF83364F  : public AbstractEventData_tAE1A127ED657117548181D29FFE4B1B14D8E67F7
{
	// UnityEngine.EventSystems.EventSystem UnityEngine.EventSystems.BaseEventData::m_EventSystem
	EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* ___m_EventSystem_1;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// UnityEngine.Color
struct Color_tD001788D726C3A7F1379BEED0260B9591F440C1F 
{
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;
};

// UnityEngine.DrivenRectTransformTracker
struct DrivenRectTransformTracker_tFB0706C933E3C68E4F377C204FCEEF091F1EE0B1 
{
	union
	{
		struct
		{
		};
		uint8_t DrivenRectTransformTracker_tFB0706C933E3C68E4F377C204FCEEF091F1EE0B1__padding[1];
	};
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// UnityEngine.UI.Navigation
struct Navigation_t4D2E201D65749CF4E104E8AC1232CF1D6F14795C 
{
	// UnityEngine.UI.Navigation/Mode UnityEngine.UI.Navigation::m_Mode
	int32_t ___m_Mode_0;
	// System.Boolean UnityEngine.UI.Navigation::m_WrapAround
	bool ___m_WrapAround_1;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnUp
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnUp_2;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnDown
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnDown_3;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnLeft
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnLeft_4;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnRight
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnRight_5;
};
// Native definition for P/Invoke marshalling of UnityEngine.UI.Navigation
struct Navigation_t4D2E201D65749CF4E104E8AC1232CF1D6F14795C_marshaled_pinvoke
{
	int32_t ___m_Mode_0;
	int32_t ___m_WrapAround_1;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnUp_2;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnDown_3;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnLeft_4;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnRight_5;
};
// Native definition for COM marshalling of UnityEngine.UI.Navigation
struct Navigation_t4D2E201D65749CF4E104E8AC1232CF1D6F14795C_marshaled_com
{
	int32_t ___m_Mode_0;
	int32_t ___m_WrapAround_1;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnUp_2;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnDown_3;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnLeft_4;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnRight_5;
};

// UnityEngine.Rect
struct Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D 
{
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// UnityEngine.UI.SpriteState
struct SpriteState_tC8199570BE6337FB5C49347C97892B4222E5AACD 
{
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_HighlightedSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_HighlightedSprite_0;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_PressedSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_PressedSprite_1;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_SelectedSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_SelectedSprite_2;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_DisabledSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_DisabledSprite_3;
};
// Native definition for P/Invoke marshalling of UnityEngine.UI.SpriteState
struct SpriteState_tC8199570BE6337FB5C49347C97892B4222E5AACD_marshaled_pinvoke
{
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_HighlightedSprite_0;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_PressedSprite_1;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_SelectedSprite_2;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_DisabledSprite_3;
};
// Native definition for COM marshalling of UnityEngine.UI.SpriteState
struct SpriteState_tC8199570BE6337FB5C49347C97892B4222E5AACD_marshaled_com
{
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_HighlightedSprite_0;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_PressedSprite_1;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_SelectedSprite_2;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_DisabledSprite_3;
};

// UnityEngine.Events.UnityEvent
struct UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977  : public UnityEventBase_t4968A4C72559F35C0923E4BD9C042C3A842E1DB8
{
	// System.Object[] UnityEngine.Events.UnityEvent::m_InvokeArray
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___m_InvokeArray_3;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;
};

struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields
{
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___negativeInfinityVector_9;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// UnityEngine.Vector4
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 
{
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;
};

struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_StaticFields
{
	// UnityEngine.Vector4 UnityEngine.Vector4::zeroVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___zeroVector_5;
	// UnityEngine.Vector4 UnityEngine.Vector4::oneVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___oneVector_6;
	// UnityEngine.Vector4 UnityEngine.Vector4::positiveInfinityVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___positiveInfinityVector_7;
	// UnityEngine.Vector4 UnityEngine.Vector4::negativeInfinityVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___negativeInfinityVector_8;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// UnityEngine.WaitForEndOfFrame
struct WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663  : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D
{
};

// UnityEngine.WaitForSeconds
struct WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3  : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D
{
	// System.Single UnityEngine.WaitForSeconds::m_Seconds
	float ___m_Seconds_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_marshaled_pinvoke : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_pinvoke
{
	float ___m_Seconds_0;
};
// Native definition for COM marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_marshaled_com : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_com
{
	float ___m_Seconds_0;
};

// UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354  : public RuntimeObject
{
	// System.IntPtr UnityEngine.AnimationCurve::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// UnityEngine.UI.ColorBlock
struct ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 
{
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_NormalColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_NormalColor_0;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_HighlightedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_HighlightedColor_1;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_PressedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_PressedColor_2;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_SelectedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_SelectedColor_3;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_DisabledColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_DisabledColor_4;
	// System.Single UnityEngine.UI.ColorBlock::m_ColorMultiplier
	float ___m_ColorMultiplier_5;
	// System.Single UnityEngine.UI.ColorBlock::m_FadeDuration
	float ___m_FadeDuration_6;
};

struct ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11_StaticFields
{
	// UnityEngine.UI.ColorBlock UnityEngine.UI.ColorBlock::defaultColorBlock
	ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 ___defaultColorBlock_7;
};

// UnityEngine.Coroutine
struct Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B  : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D
{
	// System.IntPtr UnityEngine.Coroutine::m_Ptr
	intptr_t ___m_Ptr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Coroutine
struct Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B_marshaled_pinvoke : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.Coroutine
struct Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B_marshaled_com : public YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};

struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};

struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.EventSystems.RaycastResult
struct RaycastResult_tEC6A7B7CABA99C386F054F01E498AEC426CF8023 
{
	// UnityEngine.GameObject UnityEngine.EventSystems.RaycastResult::m_GameObject
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_GameObject_0;
	// UnityEngine.EventSystems.BaseRaycaster UnityEngine.EventSystems.RaycastResult::module
	BaseRaycaster_t7DC8158FD3CA0193455344379DD5FF7CD5F1F832* ___module_1;
	// System.Single UnityEngine.EventSystems.RaycastResult::distance
	float ___distance_2;
	// System.Single UnityEngine.EventSystems.RaycastResult::index
	float ___index_3;
	// System.Int32 UnityEngine.EventSystems.RaycastResult::depth
	int32_t ___depth_4;
	// System.Int32 UnityEngine.EventSystems.RaycastResult::sortingLayer
	int32_t ___sortingLayer_5;
	// System.Int32 UnityEngine.EventSystems.RaycastResult::sortingOrder
	int32_t ___sortingOrder_6;
	// UnityEngine.Vector3 UnityEngine.EventSystems.RaycastResult::worldPosition
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___worldPosition_7;
	// UnityEngine.Vector3 UnityEngine.EventSystems.RaycastResult::worldNormal
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___worldNormal_8;
	// UnityEngine.Vector2 UnityEngine.EventSystems.RaycastResult::screenPosition
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___screenPosition_9;
	// System.Int32 UnityEngine.EventSystems.RaycastResult::displayIndex
	int32_t ___displayIndex_10;
};
// Native definition for P/Invoke marshalling of UnityEngine.EventSystems.RaycastResult
struct RaycastResult_tEC6A7B7CABA99C386F054F01E498AEC426CF8023_marshaled_pinvoke
{
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_GameObject_0;
	BaseRaycaster_t7DC8158FD3CA0193455344379DD5FF7CD5F1F832* ___module_1;
	float ___distance_2;
	float ___index_3;
	int32_t ___depth_4;
	int32_t ___sortingLayer_5;
	int32_t ___sortingOrder_6;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___worldPosition_7;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___worldNormal_8;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___screenPosition_9;
	int32_t ___displayIndex_10;
};
// Native definition for COM marshalling of UnityEngine.EventSystems.RaycastResult
struct RaycastResult_tEC6A7B7CABA99C386F054F01E498AEC426CF8023_marshaled_com
{
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_GameObject_0;
	BaseRaycaster_t7DC8158FD3CA0193455344379DD5FF7CD5F1F832* ___module_1;
	float ___distance_2;
	float ___index_3;
	int32_t ___depth_4;
	int32_t ___sortingLayer_5;
	int32_t ___sortingOrder_6;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___worldPosition_7;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___worldNormal_8;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___screenPosition_9;
	int32_t ___displayIndex_10;
};

// Ricimi.AnimatedButton/ButtonClickedEvent
struct ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8  : public UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977
{
};

// Ricimi.TintedButton/ButtonClickedEvent
struct ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E  : public UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977
{
};

// Ricimi.Transition/<RunFade>d__5
struct U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D  : public RuntimeObject
{
	// System.Int32 Ricimi.Transition/<RunFade>d__5::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Ricimi.Transition/<RunFade>d__5::<>2__current
	RuntimeObject* ___U3CU3E2__current_1;
	// UnityEngine.Color Ricimi.Transition/<RunFade>d__5::fadeColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___fadeColor_2;
	// Ricimi.Transition Ricimi.Transition/<RunFade>d__5::<>4__this
	Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* ___U3CU3E4__this_3;
	// System.Single Ricimi.Transition/<RunFade>d__5::duration
	float ___duration_4;
	// System.String Ricimi.Transition/<RunFade>d__5::level
	String_t* ___level_5;
	// UnityEngine.UI.Image Ricimi.Transition/<RunFade>d__5::<image>5__2
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___U3CimageU3E5__2_6;
	// System.Single Ricimi.Transition/<RunFade>d__5::<time>5__3
	float ___U3CtimeU3E5__3_7;
	// System.Single Ricimi.Transition/<RunFade>d__5::<halfDuration>5__4
	float ___U3ChalfDurationU3E5__4_8;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Material
struct Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.EventSystems.PointerEventData
struct PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB  : public BaseEventData_tE03A848325C0AE8E76C6CA15FD86395EBF83364F
{
	// UnityEngine.GameObject UnityEngine.EventSystems.PointerEventData::<pointerEnter>k__BackingField
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___U3CpointerEnterU3Ek__BackingField_2;
	// UnityEngine.GameObject UnityEngine.EventSystems.PointerEventData::m_PointerPress
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_PointerPress_3;
	// UnityEngine.GameObject UnityEngine.EventSystems.PointerEventData::<lastPress>k__BackingField
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___U3ClastPressU3Ek__BackingField_4;
	// UnityEngine.GameObject UnityEngine.EventSystems.PointerEventData::<rawPointerPress>k__BackingField
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___U3CrawPointerPressU3Ek__BackingField_5;
	// UnityEngine.GameObject UnityEngine.EventSystems.PointerEventData::<pointerDrag>k__BackingField
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___U3CpointerDragU3Ek__BackingField_6;
	// UnityEngine.GameObject UnityEngine.EventSystems.PointerEventData::<pointerClick>k__BackingField
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___U3CpointerClickU3Ek__BackingField_7;
	// UnityEngine.EventSystems.RaycastResult UnityEngine.EventSystems.PointerEventData::<pointerCurrentRaycast>k__BackingField
	RaycastResult_tEC6A7B7CABA99C386F054F01E498AEC426CF8023 ___U3CpointerCurrentRaycastU3Ek__BackingField_8;
	// UnityEngine.EventSystems.RaycastResult UnityEngine.EventSystems.PointerEventData::<pointerPressRaycast>k__BackingField
	RaycastResult_tEC6A7B7CABA99C386F054F01E498AEC426CF8023 ___U3CpointerPressRaycastU3Ek__BackingField_9;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> UnityEngine.EventSystems.PointerEventData::hovered
	List_1_tB951CE80B58D1BF9650862451D8DAD8C231F207B* ___hovered_10;
	// System.Boolean UnityEngine.EventSystems.PointerEventData::<eligibleForClick>k__BackingField
	bool ___U3CeligibleForClickU3Ek__BackingField_11;
	// System.Int32 UnityEngine.EventSystems.PointerEventData::<pointerId>k__BackingField
	int32_t ___U3CpointerIdU3Ek__BackingField_12;
	// UnityEngine.Vector2 UnityEngine.EventSystems.PointerEventData::<position>k__BackingField
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___U3CpositionU3Ek__BackingField_13;
	// UnityEngine.Vector2 UnityEngine.EventSystems.PointerEventData::<delta>k__BackingField
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___U3CdeltaU3Ek__BackingField_14;
	// UnityEngine.Vector2 UnityEngine.EventSystems.PointerEventData::<pressPosition>k__BackingField
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___U3CpressPositionU3Ek__BackingField_15;
	// UnityEngine.Vector3 UnityEngine.EventSystems.PointerEventData::<worldPosition>k__BackingField
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___U3CworldPositionU3Ek__BackingField_16;
	// UnityEngine.Vector3 UnityEngine.EventSystems.PointerEventData::<worldNormal>k__BackingField
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___U3CworldNormalU3Ek__BackingField_17;
	// System.Single UnityEngine.EventSystems.PointerEventData::<clickTime>k__BackingField
	float ___U3CclickTimeU3Ek__BackingField_18;
	// System.Int32 UnityEngine.EventSystems.PointerEventData::<clickCount>k__BackingField
	int32_t ___U3CclickCountU3Ek__BackingField_19;
	// UnityEngine.Vector2 UnityEngine.EventSystems.PointerEventData::<scrollDelta>k__BackingField
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___U3CscrollDeltaU3Ek__BackingField_20;
	// System.Boolean UnityEngine.EventSystems.PointerEventData::<useDragThreshold>k__BackingField
	bool ___U3CuseDragThresholdU3Ek__BackingField_21;
	// System.Boolean UnityEngine.EventSystems.PointerEventData::<dragging>k__BackingField
	bool ___U3CdraggingU3Ek__BackingField_22;
	// UnityEngine.EventSystems.PointerEventData/InputButton UnityEngine.EventSystems.PointerEventData::<button>k__BackingField
	int32_t ___U3CbuttonU3Ek__BackingField_23;
	// System.Single UnityEngine.EventSystems.PointerEventData::<pressure>k__BackingField
	float ___U3CpressureU3Ek__BackingField_24;
	// System.Single UnityEngine.EventSystems.PointerEventData::<tangentialPressure>k__BackingField
	float ___U3CtangentialPressureU3Ek__BackingField_25;
	// System.Single UnityEngine.EventSystems.PointerEventData::<altitudeAngle>k__BackingField
	float ___U3CaltitudeAngleU3Ek__BackingField_26;
	// System.Single UnityEngine.EventSystems.PointerEventData::<azimuthAngle>k__BackingField
	float ___U3CazimuthAngleU3Ek__BackingField_27;
	// System.Single UnityEngine.EventSystems.PointerEventData::<twist>k__BackingField
	float ___U3CtwistU3Ek__BackingField_28;
	// UnityEngine.Vector2 UnityEngine.EventSystems.PointerEventData::<radius>k__BackingField
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___U3CradiusU3Ek__BackingField_29;
	// UnityEngine.Vector2 UnityEngine.EventSystems.PointerEventData::<radiusVariance>k__BackingField
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___U3CradiusVarianceU3Ek__BackingField_30;
	// System.Boolean UnityEngine.EventSystems.PointerEventData::<fullyExited>k__BackingField
	bool ___U3CfullyExitedU3Ek__BackingField_31;
	// System.Boolean UnityEngine.EventSystems.PointerEventData::<reentered>k__BackingField
	bool ___U3CreenteredU3Ek__BackingField_32;
};

// UnityEngine.Sprite
struct Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.SystemException
struct SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295  : public Exception_t
{
};

// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700_StaticFields
{
	// System.Int32 UnityEngine.Texture::GenerateAllMips
	int32_t ___GenerateAllMips_4;
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.CanvasRenderer
struct CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
	// System.Boolean UnityEngine.CanvasRenderer::<isMask>k__BackingField
	bool ___U3CisMaskU3Ek__BackingField_4;
};

// System.NotSupportedException
struct NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4  : public Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700
{
};

// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.Animator
struct Animator_t8A52E42AE54F76681838FE9E632683EF3952E883  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.AudioBehaviour
struct AudioBehaviour_t2DC0BEF7B020C952F3D2DA5AAAC88501C7EEB941  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.Canvas
struct Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

struct Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_StaticFields
{
	// UnityEngine.Canvas/WillRenderCanvases UnityEngine.Canvas::preWillRenderCanvases
	WillRenderCanvases_tA4A6E66DBA797DCB45B995DBA449A9D1D80D0FBC* ___preWillRenderCanvases_4;
	// UnityEngine.Canvas/WillRenderCanvases UnityEngine.Canvas::willRenderCanvases
	WillRenderCanvases_tA4A6E66DBA797DCB45B995DBA449A9D1D80D0FBC* ___willRenderCanvases_5;
	// System.Action`1<System.Int32> UnityEngine.Canvas::<externBeginRenderOverlays>k__BackingField
	Action_1_tD69A6DC9FBE94131E52F5A73B2A9D4AB51EEC404* ___U3CexternBeginRenderOverlaysU3Ek__BackingField_6;
	// System.Action`2<System.Int32,System.Int32> UnityEngine.Canvas::<externRenderOverlaysBefore>k__BackingField
	Action_2_tD7438462601D3939500ED67463331FE00CFFBDB8* ___U3CexternRenderOverlaysBeforeU3Ek__BackingField_7;
	// System.Action`1<System.Int32> UnityEngine.Canvas::<externEndRenderOverlays>k__BackingField
	Action_1_tD69A6DC9FBE94131E52F5A73B2A9D4AB51EEC404* ___U3CexternEndRenderOverlaysU3Ek__BackingField_8;
};

// UnityEngine.CanvasGroup
struct CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.RectTransform
struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5  : public Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1
{
};

struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_StaticFields
{
	// UnityEngine.RectTransform/ReapplyDrivenProperties UnityEngine.RectTransform::reapplyDrivenProperties
	ReapplyDrivenProperties_t3482EA130A01FF7EE2EEFE37F66A5215D08CFE24* ___reapplyDrivenProperties_4;
};

// UnityEngine.AudioSource
struct AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299  : public AudioBehaviour_t2DC0BEF7B020C952F3D2DA5AAAC88501C7EEB941
{
};

// Ricimi.BackgroundMusic
struct BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.AudioSource Ricimi.BackgroundMusic::m_audioSource
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ___m_audioSource_5;
};

struct BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_StaticFields
{
	// Ricimi.BackgroundMusic Ricimi.BackgroundMusic::Instance
	BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* ___Instance_4;
};

// Ricimi.ColorSwapper
struct ColorSwapper_t5F1C217CDAE4B913B63FBEADD2AC2D6D27F4171A  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.Color Ricimi.ColorSwapper::enabledColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___enabledColor_4;
	// UnityEngine.Color Ricimi.ColorSwapper::disabledColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___disabledColor_5;
	// System.Boolean Ricimi.ColorSwapper::m_swapped
	bool ___m_swapped_6;
	// UnityEngine.UI.Image Ricimi.ColorSwapper::m_image
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___m_image_7;
};

// Ricimi.Fader
struct Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// System.Single Ricimi.Fader::duration
	float ___duration_4;
	// UnityEngine.CanvasGroup Ricimi.Fader::m_canvasGroup
	CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* ___m_canvasGroup_5;
};

// Ricimi.InitialPlayerPrefs
struct InitialPlayerPrefs_tFB58CC4998B1CC4D458FD13F089ED23F01C784EA  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// Ricimi.LevelScene
struct LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.GameObject Ricimi.LevelScene::prevLevelButton
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___prevLevelButton_4;
	// UnityEngine.GameObject Ricimi.LevelScene::nextLevelButton
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___nextLevelButton_5;
	// UnityEngine.GameObject Ricimi.LevelScene::levelGroup
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___levelGroup_6;
	// UnityEngine.UI.Text Ricimi.LevelScene::levelText
	Text_tD60B2346DAA6666BF0D822FF607F0B220C2B9E62* ___levelText_7;
	// System.Int32 Ricimi.LevelScene::m_currentLevelIndex
	int32_t ___m_currentLevelIndex_9;
	// UnityEngine.Animator Ricimi.LevelScene::m_animator
	Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___m_animator_10;
};

// Ricimi.MusicButton
struct MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// Ricimi.SpriteSwapper Ricimi.MusicButton::m_spriteSwapper
	SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* ___m_spriteSwapper_4;
	// System.Boolean Ricimi.MusicButton::m_on
	bool ___m_on_5;
};

// Ricimi.MusicManager
struct MusicManager_t49777347B8E0DCB451520D9032E435E8533FC47E  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.UI.Slider Ricimi.MusicManager::m_musicSlider
	Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* ___m_musicSlider_4;
	// UnityEngine.GameObject Ricimi.MusicManager::m_musicButton
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_musicButton_5;
};

// Ricimi.MuteBackgroundMusic
struct MuteBackgroundMusic_tA2D83AF4D170E8E0B5B6CADC28C1F2390C2B9B04  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// Ricimi.BackgroundMusic Ricimi.MuteBackgroundMusic::m_bgMusic
	BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* ___m_bgMusic_4;
};

// Ricimi.Popup
struct Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.Color Ricimi.Popup::backgroundColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___backgroundColor_4;
	// UnityEngine.GameObject Ricimi.Popup::m_background
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_background_5;
};

// Ricimi.PopupOpener
struct PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.GameObject Ricimi.PopupOpener::popupPrefab
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___popupPrefab_4;
	// UnityEngine.Canvas Ricimi.PopupOpener::m_canvas
	Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* ___m_canvas_5;
};

// Ricimi.SceneTransition
struct SceneTransition_tCB626AD8A4C6B1DF87F1F55575D36D043C8C6A69  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// System.String Ricimi.SceneTransition::scene
	String_t* ___scene_4;
	// System.Single Ricimi.SceneTransition::duration
	float ___duration_5;
	// UnityEngine.Color Ricimi.SceneTransition::color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color_6;
};

// Ricimi.SoundButton
struct SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// Ricimi.SpriteSwapper Ricimi.SoundButton::m_spriteSwapper
	SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* ___m_spriteSwapper_4;
	// System.Boolean Ricimi.SoundButton::m_on
	bool ___m_on_5;
};

// Ricimi.SoundManager
struct SoundManager_t11FAAFE4BA02BF7347C1BC24FCCF11EC1DE8A7E8  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.UI.Slider Ricimi.SoundManager::m_soundSlider
	Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* ___m_soundSlider_4;
	// UnityEngine.GameObject Ricimi.SoundManager::m_soundButton
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_soundButton_5;
};

// Ricimi.SpinWheel
struct SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.AnimationCurve Ricimi.SpinWheel::AnimationCurve
	AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* ___AnimationCurve_4;
	// System.Boolean Ricimi.SpinWheel::m_spinning
	bool ___m_spinning_5;
};

// Ricimi.SpriteSwapper
struct SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.Sprite Ricimi.SpriteSwapper::enabledSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___enabledSprite_4;
	// UnityEngine.Sprite Ricimi.SpriteSwapper::disabledSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___disabledSprite_5;
	// System.Boolean Ricimi.SpriteSwapper::m_swapped
	bool ___m_swapped_6;
	// UnityEngine.UI.Image Ricimi.SpriteSwapper::m_image
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___m_image_7;
};

// Touch
struct Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// Result Touch::result
	int32_t ___result_4;
	// System.Single[] Touch::degree
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___degree_5;
	// System.Int32[] Touch::vals
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___vals_6;
	// System.Int32 Touch::index
	int32_t ___index_7;
	// Touch/Direction Touch::direction
	int32_t ___direction_8;
	// UnityEngine.Vector2 Touch::StartPosition
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___StartPosition_9;
	// UnityEngine.Vector2 Touch::LastPosition
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___LastPosition_10;
	// UnityEngine.Vector2 Touch::position
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___position_11;
	// UnityEngine.Camera Touch::MainCamera
	Camera_tA92CC927D7439999BC82DBEDC0AA45B470F9E184* ___MainCamera_12;
};

// Ricimi.Transition
struct Transition_tD3D7356191E3387D36D7B57C22E5021280E80951  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.GameObject Ricimi.Transition::m_overlay
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_overlay_5;
};

struct Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields
{
	// UnityEngine.GameObject Ricimi.Transition::m_canvas
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_canvas_4;
};

// UnityEngine.EventSystems.UIBehaviour
struct UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// Ricimi.AnimatedButton
struct AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E  : public UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D
{
	// System.Boolean Ricimi.AnimatedButton::interactable
	bool ___interactable_4;
	// Ricimi.AnimatedButton/ButtonClickedEvent Ricimi.AnimatedButton::m_OnClick
	ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* ___m_OnClick_5;
	// UnityEngine.Animator Ricimi.AnimatedButton::m_animator
	Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* ___m_animator_6;
};

// UnityEngine.UI.Graphic
struct Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931  : public UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D
{
	// UnityEngine.Material UnityEngine.UI.Graphic::m_Material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_Material_6;
	// UnityEngine.Color UnityEngine.UI.Graphic::m_Color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_Color_7;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipLayoutUpdate
	bool ___m_SkipLayoutUpdate_8;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipMaterialUpdate
	bool ___m_SkipMaterialUpdate_9;
	// System.Boolean UnityEngine.UI.Graphic::m_RaycastTarget
	bool ___m_RaycastTarget_10;
	// UnityEngine.Vector4 UnityEngine.UI.Graphic::m_RaycastPadding
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_RaycastPadding_11;
	// UnityEngine.RectTransform UnityEngine.UI.Graphic::m_RectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_RectTransform_12;
	// UnityEngine.CanvasRenderer UnityEngine.UI.Graphic::m_CanvasRenderer
	CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* ___m_CanvasRenderer_13;
	// UnityEngine.Canvas UnityEngine.UI.Graphic::m_Canvas
	Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* ___m_Canvas_14;
	// System.Boolean UnityEngine.UI.Graphic::m_VertsDirty
	bool ___m_VertsDirty_15;
	// System.Boolean UnityEngine.UI.Graphic::m_MaterialDirty
	bool ___m_MaterialDirty_16;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyLayoutCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyLayoutCallback_17;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyVertsCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyVertsCallback_18;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyMaterialCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyMaterialCallback_19;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::m_CachedMesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___m_CachedMesh_22;
	// UnityEngine.Vector2[] UnityEngine.UI.Graphic::m_CachedUvs
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___m_CachedUvs_23;
	// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween> UnityEngine.UI.Graphic::m_ColorTweenRunner
	TweenRunner_1_t5BB0582F926E75E2FE795492679A6CF55A4B4BC4* ___m_ColorTweenRunner_24;
	// System.Boolean UnityEngine.UI.Graphic::<useLegacyMeshGeneration>k__BackingField
	bool ___U3CuseLegacyMeshGenerationU3Ek__BackingField_25;
};

struct Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931_StaticFields
{
	// UnityEngine.Material UnityEngine.UI.Graphic::s_DefaultUI
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___s_DefaultUI_4;
	// UnityEngine.Texture2D UnityEngine.UI.Graphic::s_WhiteTexture
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___s_WhiteTexture_5;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::s_Mesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___s_Mesh_20;
	// UnityEngine.UI.VertexHelper UnityEngine.UI.Graphic::s_VertexHelper
	VertexHelper_tB905FCB02AE67CBEE5F265FE37A5938FC5D136FE* ___s_VertexHelper_21;
};

// Ricimi.PlayPopup
struct PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B  : public Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8
{
	// UnityEngine.Color Ricimi.PlayPopup::enabledColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___enabledColor_6;
	// UnityEngine.Color Ricimi.PlayPopup::disabledColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___disabledColor_7;
	// UnityEngine.UI.Image Ricimi.PlayPopup::leftStarImage
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___leftStarImage_8;
	// UnityEngine.UI.Image Ricimi.PlayPopup::middleStarImage
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___middleStarImage_9;
	// UnityEngine.UI.Image Ricimi.PlayPopup::rightStarImage
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___rightStarImage_10;
};

// Ricimi.PlayPopupOpener
struct PlayPopupOpener_t5A94A3B51FE3D020DC0FEDC0B71C1ADA5080CBFE  : public PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421
{
	// System.Int32 Ricimi.PlayPopupOpener::starsObtained
	int32_t ___starsObtained_6;
};

// UnityEngine.UI.Selectable
struct Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712  : public UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D
{
	// System.Boolean UnityEngine.UI.Selectable::m_EnableCalled
	bool ___m_EnableCalled_6;
	// UnityEngine.UI.Navigation UnityEngine.UI.Selectable::m_Navigation
	Navigation_t4D2E201D65749CF4E104E8AC1232CF1D6F14795C ___m_Navigation_7;
	// UnityEngine.UI.Selectable/Transition UnityEngine.UI.Selectable::m_Transition
	int32_t ___m_Transition_8;
	// UnityEngine.UI.ColorBlock UnityEngine.UI.Selectable::m_Colors
	ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 ___m_Colors_9;
	// UnityEngine.UI.SpriteState UnityEngine.UI.Selectable::m_SpriteState
	SpriteState_tC8199570BE6337FB5C49347C97892B4222E5AACD ___m_SpriteState_10;
	// UnityEngine.UI.AnimationTriggers UnityEngine.UI.Selectable::m_AnimationTriggers
	AnimationTriggers_tA0DC06F89C5280C6DD972F6F4C8A56D7F4F79074* ___m_AnimationTriggers_11;
	// System.Boolean UnityEngine.UI.Selectable::m_Interactable
	bool ___m_Interactable_12;
	// UnityEngine.UI.Graphic UnityEngine.UI.Selectable::m_TargetGraphic
	Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931* ___m_TargetGraphic_13;
	// System.Boolean UnityEngine.UI.Selectable::m_GroupsAllowInteraction
	bool ___m_GroupsAllowInteraction_14;
	// System.Int32 UnityEngine.UI.Selectable::m_CurrentIndex
	int32_t ___m_CurrentIndex_15;
	// System.Boolean UnityEngine.UI.Selectable::<isPointerInside>k__BackingField
	bool ___U3CisPointerInsideU3Ek__BackingField_16;
	// System.Boolean UnityEngine.UI.Selectable::<isPointerDown>k__BackingField
	bool ___U3CisPointerDownU3Ek__BackingField_17;
	// System.Boolean UnityEngine.UI.Selectable::<hasSelection>k__BackingField
	bool ___U3ChasSelectionU3Ek__BackingField_18;
	// System.Collections.Generic.List`1<UnityEngine.CanvasGroup> UnityEngine.UI.Selectable::m_CanvasGroupCache
	List_1_t2CDCA768E7F493F5EDEBC75AEB200FD621354E35* ___m_CanvasGroupCache_19;
};

struct Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712_StaticFields
{
	// UnityEngine.UI.Selectable[] UnityEngine.UI.Selectable::s_Selectables
	SelectableU5BU5D_t4160E135F02A40F75A63F787D36F31FEC6FE91A9* ___s_Selectables_4;
	// System.Int32 UnityEngine.UI.Selectable::s_SelectableCount
	int32_t ___s_SelectableCount_5;
};

// Ricimi.TintedButton
struct TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74  : public UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D
{
	// Ricimi.TintedButton/ButtonClickedEvent Ricimi.TintedButton::m_OnClick
	ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* ___m_OnClick_4;
	// System.Boolean Ricimi.TintedButton::m_pointerInside
	bool ___m_pointerInside_6;
	// System.Boolean Ricimi.TintedButton::m_pointerPressed
	bool ___m_pointerPressed_7;
};

// UnityEngine.UI.MaskableGraphic
struct MaskableGraphic_tFC5B6BE351C90DE53744DF2A70940242774B361E  : public Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931
{
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_ShouldRecalculateStencil
	bool ___m_ShouldRecalculateStencil_26;
	// UnityEngine.Material UnityEngine.UI.MaskableGraphic::m_MaskMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_MaskMaterial_27;
	// UnityEngine.UI.RectMask2D UnityEngine.UI.MaskableGraphic::m_ParentMask
	RectMask2D_tACF92BE999C791A665BD1ADEABF5BCEB82846670* ___m_ParentMask_28;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_Maskable
	bool ___m_Maskable_29;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_IsMaskingGraphic
	bool ___m_IsMaskingGraphic_30;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_IncludeForMasking
	bool ___m_IncludeForMasking_31;
	// UnityEngine.UI.MaskableGraphic/CullStateChangedEvent UnityEngine.UI.MaskableGraphic::m_OnCullStateChanged
	CullStateChangedEvent_t6073CD0D951EC1256BF74B8F9107D68FC89B99B8* ___m_OnCullStateChanged_32;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_ShouldRecalculate
	bool ___m_ShouldRecalculate_33;
	// System.Int32 UnityEngine.UI.MaskableGraphic::m_StencilValue
	int32_t ___m_StencilValue_34;
	// UnityEngine.Vector3[] UnityEngine.UI.MaskableGraphic::m_Corners
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___m_Corners_35;
};

// UnityEngine.UI.Slider
struct Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F  : public Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712
{
	// UnityEngine.RectTransform UnityEngine.UI.Slider::m_FillRect
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_FillRect_20;
	// UnityEngine.RectTransform UnityEngine.UI.Slider::m_HandleRect
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_HandleRect_21;
	// UnityEngine.UI.Slider/Direction UnityEngine.UI.Slider::m_Direction
	int32_t ___m_Direction_22;
	// System.Single UnityEngine.UI.Slider::m_MinValue
	float ___m_MinValue_23;
	// System.Single UnityEngine.UI.Slider::m_MaxValue
	float ___m_MaxValue_24;
	// System.Boolean UnityEngine.UI.Slider::m_WholeNumbers
	bool ___m_WholeNumbers_25;
	// System.Single UnityEngine.UI.Slider::m_Value
	float ___m_Value_26;
	// UnityEngine.UI.Slider/SliderEvent UnityEngine.UI.Slider::m_OnValueChanged
	SliderEvent_t92A82EF6C62E15AF92B640FE2D960E877E8C6555* ___m_OnValueChanged_27;
	// UnityEngine.UI.Image UnityEngine.UI.Slider::m_FillImage
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___m_FillImage_28;
	// UnityEngine.Transform UnityEngine.UI.Slider::m_FillTransform
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___m_FillTransform_29;
	// UnityEngine.RectTransform UnityEngine.UI.Slider::m_FillContainerRect
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_FillContainerRect_30;
	// UnityEngine.Transform UnityEngine.UI.Slider::m_HandleTransform
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___m_HandleTransform_31;
	// UnityEngine.RectTransform UnityEngine.UI.Slider::m_HandleContainerRect
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_HandleContainerRect_32;
	// UnityEngine.Vector2 UnityEngine.UI.Slider::m_Offset
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_Offset_33;
	// UnityEngine.DrivenRectTransformTracker UnityEngine.UI.Slider::m_Tracker
	DrivenRectTransformTracker_tFB0706C933E3C68E4F377C204FCEEF091F1EE0B1 ___m_Tracker_34;
	// System.Boolean UnityEngine.UI.Slider::m_DelayedUpdateVisuals
	bool ___m_DelayedUpdateVisuals_35;
};

// UnityEngine.UI.Image
struct Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E  : public MaskableGraphic_tFC5B6BE351C90DE53744DF2A70940242774B361E
{
	// UnityEngine.Sprite UnityEngine.UI.Image::m_Sprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_Sprite_37;
	// UnityEngine.Sprite UnityEngine.UI.Image::m_OverrideSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_OverrideSprite_38;
	// UnityEngine.UI.Image/Type UnityEngine.UI.Image::m_Type
	int32_t ___m_Type_39;
	// System.Boolean UnityEngine.UI.Image::m_PreserveAspect
	bool ___m_PreserveAspect_40;
	// System.Boolean UnityEngine.UI.Image::m_FillCenter
	bool ___m_FillCenter_41;
	// UnityEngine.UI.Image/FillMethod UnityEngine.UI.Image::m_FillMethod
	int32_t ___m_FillMethod_42;
	// System.Single UnityEngine.UI.Image::m_FillAmount
	float ___m_FillAmount_43;
	// System.Boolean UnityEngine.UI.Image::m_FillClockwise
	bool ___m_FillClockwise_44;
	// System.Int32 UnityEngine.UI.Image::m_FillOrigin
	int32_t ___m_FillOrigin_45;
	// System.Single UnityEngine.UI.Image::m_AlphaHitTestMinimumThreshold
	float ___m_AlphaHitTestMinimumThreshold_46;
	// System.Boolean UnityEngine.UI.Image::m_Tracked
	bool ___m_Tracked_47;
	// System.Boolean UnityEngine.UI.Image::m_UseSpriteMesh
	bool ___m_UseSpriteMesh_48;
	// System.Single UnityEngine.UI.Image::m_PixelsPerUnitMultiplier
	float ___m_PixelsPerUnitMultiplier_49;
	// System.Single UnityEngine.UI.Image::m_CachedReferencePixelsPerUnit
	float ___m_CachedReferencePixelsPerUnit_50;
};

struct Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_StaticFields
{
	// UnityEngine.Material UnityEngine.UI.Image::s_ETC1DefaultUI
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___s_ETC1DefaultUI_36;
	// UnityEngine.Vector2[] UnityEngine.UI.Image::s_VertScratch
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___s_VertScratch_51;
	// UnityEngine.Vector2[] UnityEngine.UI.Image::s_UVScratch
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___s_UVScratch_52;
	// UnityEngine.Vector3[] UnityEngine.UI.Image::s_Xy
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___s_Xy_53;
	// UnityEngine.Vector3[] UnityEngine.UI.Image::s_Uv
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___s_Uv_54;
	// System.Collections.Generic.List`1<UnityEngine.UI.Image> UnityEngine.UI.Image::m_TrackedTexturelessImages
	List_1_tE6BB71ABF15905EFA2BE92C38A2716547AEADB19* ___m_TrackedTexturelessImages_55;
	// System.Boolean UnityEngine.UI.Image::s_Initialized
	bool ___s_Initialized_56;
};

// UnityEngine.UI.Text
struct Text_tD60B2346DAA6666BF0D822FF607F0B220C2B9E62  : public MaskableGraphic_tFC5B6BE351C90DE53744DF2A70940242774B361E
{
	// UnityEngine.UI.FontData UnityEngine.UI.Text::m_FontData
	FontData_tB8E562846C6CB59C43260F69AE346B9BF3157224* ___m_FontData_36;
	// System.String UnityEngine.UI.Text::m_Text
	String_t* ___m_Text_37;
	// UnityEngine.TextGenerator UnityEngine.UI.Text::m_TextCache
	TextGenerator_t85D00417640A53953556C01F9D4E7DDE1ABD8FEC* ___m_TextCache_38;
	// UnityEngine.TextGenerator UnityEngine.UI.Text::m_TextCacheForLayout
	TextGenerator_t85D00417640A53953556C01F9D4E7DDE1ABD8FEC* ___m_TextCacheForLayout_39;
	// System.Boolean UnityEngine.UI.Text::m_DisableFontTextureRebuiltCallback
	bool ___m_DisableFontTextureRebuiltCallback_41;
	// UnityEngine.UIVertex[] UnityEngine.UI.Text::m_TempVerts
	UIVertexU5BU5D_tBC532486B45D071A520751A90E819C77BA4E3D2F* ___m_TempVerts_42;
};

struct Text_tD60B2346DAA6666BF0D822FF607F0B220C2B9E62_StaticFields
{
	// UnityEngine.Material UnityEngine.UI.Text::s_DefaultText
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___s_DefaultText_40;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C  : public RuntimeArray
{
	ALIGN_FIELD (8) int32_t m_Items[1];

	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C  : public RuntimeArray
{
	ALIGN_FIELD (8) float m_Items[1];

	inline float GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline float* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, float value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline float GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline float* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, float value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.UI.Image[]
struct ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78  : public RuntimeArray
{
	ALIGN_FIELD (8) Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* m_Items[1];

	inline Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// T UnityEngine.Component::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// T[] UnityEngine.GameObject::GetComponentsInChildren<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* GameObject_GetComponentsInChildren_TisRuntimeObject_m6F69570C0224EE6620FD43C4DDB0F0AB152A1B20_gshared (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// T UnityEngine.Object::Instantiate<System.Object>(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Object_Instantiate_TisRuntimeObject_m90A1E6C4C2B445D2E848DB75C772D1B95AAC046A_gshared (RuntimeObject* ___original0, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// T[] UnityEngine.Component::GetComponentsInChildren<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* Component_GetComponentsInChildren_TisRuntimeObject_m1F5B6FC0689B07D4FAAC0C605D9B2933A9B32543_gshared (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;

// System.Void Touch::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Reset_mCAD881CB2B776D9F0C8FB5F661D89B8A1E306908 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Input::GetMouseButtonDown(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetMouseButtonDown_m8DFC792D15FFF15D311614D5CC6C5D055E5A1DE3 (int32_t ___button0, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Input::get_mousePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C (const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___x0, float ___y1, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Input::GetMouseButton(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetMouseButton_m4995DD4A2D4F916565C1B1B5AAF7DF17C126B3EA (int32_t ___button0, const RuntimeMethod* method) ;
// System.Void Touch::DegreeCheck()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_DegreeCheck_mC5F846CA4B25BEF05C9575530B32F5395B7710B7 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Input::GetMouseButtonUp(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetMouseButtonUp_mBE89CC9C69BBEA9A863819E77EA54411B0476ED6 (int32_t ___button0, const RuntimeMethod* method) ;
// System.Void Touch::GestureRecognize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_GestureRecognize_m8A8CB7AE4B20D249C809CED60651CCE7A0A6572F (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::op_Subtraction(UnityEngine.Vector2,UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___a0, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___b1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.Void Touch::Triangle_Check()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Triangle_Check_m8C7D33EA6A5C13ADFD7F0DB8D34BCF91190442BD (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) ;
// System.Void Touch::StraightLine_Check()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_StraightLine_Check_mC2B42F2818D3B2DB4607C0671E44B8A1629E2A59 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) ;
// System.Void Touch::Circle_Check()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Circle_Check_m56856589F139A25A36EFE690D607E79483CBD8F2 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) ;
// System.Void Touch::Z_Check()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Z_Check_m429AB8C41A323515BF7229D012061C11A3178B1F (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.EventSystems.UIBehaviour::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UIBehaviour_Start_mB12643ED6D859CD3682B4BF5B9CA7F72E8A72B45 (UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D* __this, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<UnityEngine.Animator>()
inline Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* Component_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_m1C9FCB4BBE56BEC6BDEF6E4BA1E5DFF91614D7CE (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// UnityEngine.EventSystems.PointerEventData/InputButton UnityEngine.EventSystems.PointerEventData::get_button()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t PointerEventData_get_button_mA8CBDAF2E16927E6952BC60040D56630BCC95B0B_inline (PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.AnimatedButton::Press()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatedButton_Press_m4A7A582EDEEA373B0BB82D13EE71DD7821F42578 (AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::SetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTrigger_mC9CD54D627C8843EF6E159E167449D216EF6EB30 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___name0, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::Invoke(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour_Invoke_mF724350C59362B0F1BFE26383209A274A29A63FB (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, String_t* ___methodName0, float ___time1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityEvent::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2 (UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.AnimatedButton/ButtonClickedEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonClickedEvent__ctor_mFB69F67184B04E2D2466B0693DABF728823F7C8D (ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.EventSystems.UIBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UIBehaviour__ctor_m24C66A65DDD996E779871C6655CF11B871F11337 (UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityEvent__ctor_m03D3E5121B9A6100351984D0CE3050B909CD3235 (UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___x0, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___y1, const RuntimeMethod* method) ;
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::DestroyImmediate(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_DestroyImmediate_m6336EBC83591A5DB64EC70C92132824C6E258705 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___obj0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::DontDestroyOnLoad(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_DontDestroyOnLoad_m4B70C3AEF886C176543D1295507B6455C9DCAEA7 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___target0, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<UnityEngine.AudioSource>()
inline AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* Component_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m42DA4DEA19EB60D80CBED7413ADEB27FA033C77B (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// System.Void UnityEngine.AudioSource::set_ignoreListenerVolume(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_ignoreListenerVolume_mAB973FFB2B666C4C6DE3BF34C930C28CC315731D (AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.PlayerPrefs::GetInt(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987 (String_t* ___key0, const RuntimeMethod* method) ;
// System.Void UnityEngine.AudioSource::set_volume(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_volume_mD902BBDBBDE0E3C148609BF3C05096148E90F2C0 (AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* __this, float ___value0, const RuntimeMethod* method) ;
// System.Void UnityEngine.AudioListener::set_volume(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioListener_set_volume_m72BAF2D558A5449091A59630EBF48095DEB4C721 (float ___value0, const RuntimeMethod* method) ;
// System.Collections.IEnumerator Ricimi.BackgroundMusic::FadeAudio(System.Single,Ricimi.BackgroundMusic/Fade)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* BackgroundMusic_FadeAudio_mD7398B28240D708B158C36E048E4841A73E62C85 (BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* __this, float ___time0, int32_t ___fadeType1, const RuntimeMethod* method) ;
// UnityEngine.Coroutine UnityEngine.MonoBehaviour::StartCoroutine(System.Collections.IEnumerator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812 (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, RuntimeObject* ___routine0, const RuntimeMethod* method) ;
// System.Void Ricimi.BackgroundMusic/<FadeAudio>d__6::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CFadeAudioU3Ed__6__ctor_m687944A3905C69B94A4993E8D36271A36842346F (U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Time::get_deltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_deltaTime_mC3195000401F0FD167DD2F948FD2BC58330D0865 (const RuntimeMethod* method) ;
// System.Single UnityEngine.Mathf::Lerp(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline (float ___a0, float ___b1, float ___t2, const RuntimeMethod* method) ;
// System.Void UnityEngine.WaitForSeconds::.ctor(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForSeconds__ctor_m579F95BADEDBAB4B3A7E302C6EE3995926EF2EFC (WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3* __this, float ___seconds0, const RuntimeMethod* method) ;
// System.Void System.NotSupportedException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* __this, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<UnityEngine.UI.Image>()
inline Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* Component_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mE74EE63C85A63FC34DCFC631BC229207B420BC79 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// T UnityEngine.Component::GetComponent<UnityEngine.CanvasGroup>()
inline CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* Component_GetComponent_TisCanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094_mA3B0428368982ED39ADEBB220EE67D1E99D8B2D2 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// System.Collections.IEnumerator Ricimi.Fader::RunFadeIn()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Fader_RunFadeIn_mB12ED0B7591B11E3BD1C479DAAE2BDB883F7AEC6 (Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* __this, const RuntimeMethod* method) ;
// System.Collections.IEnumerator Ricimi.Fader::RunFadeOut()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Fader_RunFadeOut_mFFA3099CB41258FE67A256EF90F6F914DBB1F4E4 (Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.Fader/<RunFadeIn>d__5::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeInU3Ed__5__ctor_mE355828D91A7F1F4D98929FFF387D5416D5F07C1 (U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) ;
// System.Void Ricimi.Fader/<RunFadeOut>d__6::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeOutU3Ed__6__ctor_m9F0F922BFEF5952EFDAED815119E4E7FF5F8C018 (U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) ;
// System.Single UnityEngine.CanvasGroup::get_alpha()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float CanvasGroup_get_alpha_mBFEA193D2886B27CC53B31F90F7A1659B67ED6DF (CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.CanvasGroup::set_alpha(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CanvasGroup_set_alpha_m5C06839316D948BB4F75ED72C87FA1F1A20C333F (CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* __this, float ___value0, const RuntimeMethod* method) ;
// System.Void UnityEngine.WaitForEndOfFrame::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForEndOfFrame__ctor_m4AF7E576C01E6B04443BB898B1AE5D645F7D45AB (WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.CanvasGroup::set_interactable(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CanvasGroup_set_interactable_m86928BB0894EF3F06BC7BE63594272FBA0DAC757 (CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Void UnityEngine.CanvasGroup::set_blocksRaycasts(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CanvasGroup_set_blocksRaycasts_m6C17F35782D16AE3FC42FCD1A4D68E1C4A4776E0 (CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.PlayerPrefs::HasKey(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayerPrefs_HasKey_mCA5C64BBA6BF8B230BC3BC92B4761DD3B11D4668 (String_t* ___key0, const RuntimeMethod* method) ;
// System.Void UnityEngine.PlayerPrefs::SetInt(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayerPrefs_SetInt_m956D3E2DB966F20CF42F842880DDF9E2BE94D948 (String_t* ___key0, int32_t ___value1, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<UnityEngine.Animator>()
inline Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* GameObject_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_mB84A0931B2081CCADE7C5D459B2A8FAA6D3D3BD3 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.Void Ricimi.LevelScene::SetLevelText(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_SetLevelText_m5FFCF3901318FBB567217F1B986039653DE4B693 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, int32_t ___level0, const RuntimeMethod* method) ;
// UnityEngine.AnimatorStateInfo UnityEngine.Animator::GetCurrentAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 Animator_GetCurrentAnimatorStateInfo_mD5B526FA605F6CFBC31B7DE36740F6AD1E534CAD (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, int32_t ___layerIndex0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AnimatorStateInfo::IsName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_IsName_mB936F493D6BDDB9372C8E9D813CE0416B002C4D0 (AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2* __this, String_t* ___name0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Animator::Play(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_m0F6A9F84B2E256E644D56C34A7A9BD622CB00FF9 (Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* __this, String_t* ___stateName0, const RuntimeMethod* method) ;
// System.Void Ricimi.LevelScene::DisablePrevLevelButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_DisablePrevLevelButton_mE3856D7E5E195B74D6D572199454534C4CECC897 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.LevelScene::EnablePrevLevelButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_EnablePrevLevelButton_m3840739BCC8B4D2247839817C268A407DD12117E (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.LevelScene::EnableNextLevelButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_EnableNextLevelButton_m26149E54E47768E75DA515DA7ACAD42BBF5F2024 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.LevelScene::DisableNextLevelButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_DisableNextLevelButton_m2D977B427742B6D16D02C651A59FC26FA34FFDC2 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) ;
// T[] UnityEngine.GameObject::GetComponentsInChildren<UnityEngine.UI.Image>()
inline ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponentsInChildren_TisRuntimeObject_m6F69570C0224EE6620FD43C4DDB0F0AB152A1B20_gshared)(__this, method);
}
// T UnityEngine.GameObject::GetComponent<Ricimi.AnimatedButton>()
inline AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.String System.Int32::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5 (int32_t* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9E3155FB84015C823606188F53B47CB44C444991 (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<Ricimi.SpriteSwapper>()
inline SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* Component_GetComponent_TisSpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8_m2100FD891B70F2F1919338CF4A2452B5E85F5A0B (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// System.Void Ricimi.SpriteSwapper::SwapSprite()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpriteSwapper_SwapSprite_mE2DC50C18D11F1D530793CF67A6FA6B58D31B7B5 (SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* __this, const RuntimeMethod* method) ;
// UnityEngine.GameObject UnityEngine.GameObject::Find(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* GameObject_Find_m7A669B4EEC2617AB82F6E3FF007CDCD9F21DB300 (String_t* ___name0, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<UnityEngine.AudioSource>()
inline AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* GameObject_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m4F30DAB8E5B57E8DB6BD8C0C3BB11CCB57690C4A (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// T UnityEngine.Component::GetComponent<UnityEngine.UI.Slider>()
inline Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* Component_GetComponent_TisSlider_t87EA570E3D6556CABF57456C2F3873FFD86E652F_mCE53A354B934E9BDB2E8D3094F4E33EBA8FFAFBA (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// T UnityEngine.GameObject::GetComponent<Ricimi.MusicButton>()
inline MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467* GameObject_GetComponent_TisMusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467_m96FF2F4E6BDD0A9AADEE7E112EB966D9DC016DBD (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.Void Ricimi.MusicButton::ToggleSprite()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MusicButton_ToggleSprite_mF41D35873F23AC4E7F101AA2A8AA75F738C9FE6B (MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467* __this, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<Ricimi.BackgroundMusic>()
inline BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* GameObject_GetComponent_TisBackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_m4B9C60B03C34C49C717FA17E9D4DBE7F8625C163 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.Void Ricimi.BackgroundMusic::FadeOut()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BackgroundMusic_FadeOut_m370AC979E7010F5A1209574DEFD5C0A34F3494B0 (BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.BackgroundMusic::FadeIn()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BackgroundMusic_FadeIn_mB5A32B16E2569C9A0B591BF14E5063DC1C2BD859 (BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.Popup::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup__ctor_mD3C4BECC4CB9730A97436435F24272C69A3A2A08 (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) ;
// T UnityEngine.Object::Instantiate<UnityEngine.GameObject>(T)
inline GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m10D87C6E0708CA912BBB02555BF7D0FBC5D7A2B3 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___original0, const RuntimeMethod* method)
{
	return ((  GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))Object_Instantiate_TisRuntimeObject_m90A1E6C4C2B445D2E848DB75C772D1B95AAC046A_gshared)(___original0, method);
}
// System.Void UnityEngine.GameObject::SetActive(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, bool ___value0, const RuntimeMethod* method) ;
// UnityEngine.Transform UnityEngine.GameObject::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline (const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_localScale(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) ;
// UnityEngine.Transform UnityEngine.Component::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::SetParent(UnityEngine.Transform,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_SetParent_m9BDD7B7476714B2D7919B10BDC22CE75C0A0A195 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___parent0, bool ___worldPositionStays1, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<Ricimi.PlayPopup>()
inline PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B* GameObject_GetComponent_TisPlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B_m9955D8B5067AA7DBEBD6120D0AFA6D09DAFDA63B (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.Void Ricimi.Popup::Open()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup_Open_mDD3ECD2152C34FF982A63C25292C9294342568C0 (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.PlayPopup::SetAchievedStars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayPopup_SetAchievedStars_m6B112EDB0AE29058233F47619B6DDFBAA98ACF32 (PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B* __this, int32_t ___starsObtained0, const RuntimeMethod* method) ;
// System.Void Ricimi.PopupOpener::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PopupOpener__ctor_m9DA91471383B49B98CC7FBB2AE19DD0E67347799 (PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.Popup::AddBackground()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup_AddBackground_mE0A908E55F431C2D0523F6B485C9CE795B667C6A (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.Popup::RemoveBackground()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup_RemoveBackground_mB4FB2F9FE36E2F38D17ADE9665565520864B61E3 (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) ;
// System.Collections.IEnumerator Ricimi.Popup::RunPopupDestroy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Popup_RunPopupDestroy_mB2DBEBD8D0C59F6547691501816942B0B8984EFB (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.Popup/<RunPopupDestroy>d__4::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunPopupDestroyU3Ed__4__ctor_m0737A7A1D9AC67899E272C7A4B1EA9E10D6AAB15 (U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, int32_t ___width0, int32_t ___height1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::SetPixel(System.Int32,System.Int32,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixel_m2CCFC5F729135D59DC4A697C2605A3FC5C8574DB (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, int32_t ___x0, int32_t ___y1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color2, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::Apply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.GameObject::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, String_t* ___name0, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<UnityEngine.UI.Image>()
inline Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* GameObject_AddComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA327C9E1CA12BC531D587E7567F2067B96E6B6A0 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared)(__this, method);
}
// System.Void UnityEngine.Rect::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23 (Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D* __this, float ___x0, float ___y1, float ___width2, float ___height3, const RuntimeMethod* method) ;
// UnityEngine.Sprite UnityEngine.Sprite::Create(UnityEngine.Texture2D,UnityEngine.Rect,UnityEngine.Vector2,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* Sprite_Create_m95F90AD74982187C087F4FA00947045A033D0BA1 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___texture0, Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D ___rect1, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___pivot2, float ___pixelsPerUnit3, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::set_mainTexture(UnityEngine.Texture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_set_mainTexture_m389E048BA9C81B603EBF36BD792212B296317AC0 (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___value0, const RuntimeMethod* method) ;
// System.Void UnityEngine.UI.Image::set_sprite(UnityEngine.Sprite)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE (Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* __this, Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___value0, const RuntimeMethod* method) ;
// UnityEngine.CanvasRenderer UnityEngine.UI.Graphic::get_canvasRenderer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* Graphic_get_canvasRenderer_m62AB727277A28728264860232642DA6EC20DEAB1 (Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.CanvasRenderer::SetAlpha(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CanvasRenderer_SetAlpha_m97E196A1CC718DE16300954D25B4125952D7632C (CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* __this, float ___alpha0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<UnityEngine.RectTransform>()
inline RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// UnityEngine.Vector2 UnityEngine.RectTransform::get_sizeDelta()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 RectTransform_get_sizeDelta_m822A8493F2035677384F1540A2E9E5ACE63010BB (RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.RectTransform::set_sizeDelta(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RectTransform_set_sizeDelta_mC9A980EA6036E6725EF24CEDF3EE80A9B2B50EE5 (RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___value0, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Transform::GetSiblingIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Transform_GetSiblingIndex_m45EE497589C36D1FBED87FB802BD80A95CE68575 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::SetSiblingIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_SetSiblingIndex_m8A3B81F08B93991C05BFA89ADA2146836C4FC4B2 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, int32_t ___index0, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<UnityEngine.UI.Image>()
inline Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* GameObject_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA59EA7D5F9133B2593F4AB70B099928BA955EE7D (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___r0, float ___g1, float ___b2, float ___a3, const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___obj0, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>()
inline Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* GameObject_GetComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_mE5A2711FA84F57F5EA0876DB106B1A146956CEFE (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// T UnityEngine.GameObject::GetComponent<Ricimi.Popup>()
inline Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* GameObject_GetComponent_TisPopup_tC1E66E522EA4DBB41FC326155A497B0D820337F8_m9E3A528EE1D81D2B08C1650C99FFE3D108BD89B9 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.Void Ricimi.Transition::LoadLevel(System.String,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transition_LoadLevel_m91F593BEC887DF1F9C68F093CB0A021A77A7592D (String_t* ___level0, float ___duration1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color2, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::get_black()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_black_mB50217951591A045844C61E7FF31EEE3FEF16737_inline (const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<Ricimi.SoundButton>()
inline SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554* GameObject_GetComponent_TisSoundButton_t3E516F24DF47C4E25F3870D7687C058064176554_mA298D7DA24E33499C8038ADD34ED3BC16E96B090 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.Void Ricimi.SoundButton::ToggleSprite()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SoundButton_ToggleSprite_mBB9667A5EBCF46A07B72852273ADFC694C52045A (SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554* __this, const RuntimeMethod* method) ;
// System.Collections.IEnumerator Ricimi.SpinWheel::DoSpin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* SpinWheel_DoSpin_m579F3C76866BA086536D8BF5CA51D7F6234E2499 (SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.SpinWheel/<DoSpin>d__3::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CDoSpinU3Ed__3__ctor_mFB2287FE370B3BA99BD4BD90B98133AE2AF38C5A (U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Transform::get_eulerAngles()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Transform_get_eulerAngles_mCAAF48EFCF628F1ED91C2FFE75A4FD19C039DD6A (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.AnimationCurve::Evaluate(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationCurve_Evaluate_m50B857043DE251A186032ADBCBB4CEF817F4EE3C (AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* __this, float ___time0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_eulerAngles(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_eulerAngles_m9F0BC484A7915A51FAB87230644229B75BACA004 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) ;
// System.Void Ricimi.TintedButton::Press()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_Press_m18C49B8D2DA957BA2A4099819E9D04EDFD4DA2F8 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.TintedButton::Unpress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_Unpress_mBB8BAB07FB858376C54E8DEF040B8F45B91257E2 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.TintedButton::Darken()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_Darken_mC049412477087BA57C8BB4903E4016A0636062A9 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) ;
// System.Void Ricimi.TintedButton::Brighten()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_Brighten_mFD95A1269BD81BA91498A716E4A819FD3A522B68 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) ;
// T[] UnityEngine.Component::GetComponentsInChildren<UnityEngine.UI.Image>()
inline ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* Component_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_m755CF1DB6A65043AC21E6F3153B9060B358DCC64 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponentsInChildren_TisRuntimeObject_m1F5B6FC0689B07D4FAAC0C605D9B2933A9B32543_gshared)(__this, method);
}
// System.Collections.IEnumerator Ricimi.TintedButton::DarkenColor(UnityEngine.UI.Image)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* TintedButton_DarkenColor_m12D94451464E68FD85D025C020BFDA5D103159AF (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___image0, const RuntimeMethod* method) ;
// System.Collections.IEnumerator Ricimi.TintedButton::BrightenColor(UnityEngine.UI.Image)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* TintedButton_BrightenColor_mE7076B94B4B57A99C6D42C65B6903BBCE215D072 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___image0, const RuntimeMethod* method) ;
// System.Void Ricimi.TintedButton/<DarkenColor>d__16::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CDarkenColorU3Ed__16__ctor_mD8802F5C9B230BAFFBCA94B51C9508FE380A0228 (U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) ;
// System.Void Ricimi.TintedButton/<BrightenColor>d__17::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CBrightenColorU3Ed__17__ctor_mF812D99D9D7073067A921DA7A9B4FEC06EB8D40D (U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) ;
// System.Void Ricimi.TintedButton/ButtonClickedEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonClickedEvent__ctor_m11E8CE22A5F284BA47538B195E671ED435A7DD44 (ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* __this, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<UnityEngine.Canvas>()
inline Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* GameObject_AddComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_m13C85FD585C0679530F8B35D0B39D965702FD0F5 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared)(__this, method);
}
// System.Void UnityEngine.Canvas::set_renderMode(UnityEngine.RenderMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Canvas_set_renderMode_mD73E953F8A115CF469508448A00D0EDAFAF5AB47 (Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* __this, int32_t ___value0, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<Ricimi.Transition>()
inline Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* GameObject_AddComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_mD73B7D6B9F588A50174DF721AF3EDEA2B35A0121 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared)(__this, method);
}
// T UnityEngine.GameObject::GetComponent<Ricimi.Transition>()
inline Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* GameObject_GetComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_m064CAE44C544384024AE4043702D2BEC084DF9EC (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.Void Ricimi.Transition::StartFade(System.String,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transition_StartFade_mDC18A7ECE5395AFFACB3A65963FB4E01F1139745 (Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* __this, String_t* ___level0, float ___duration1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___fadeColor2, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::SetAsLastSibling()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_SetAsLastSibling_m848AF1A0B4C7912FE88D8CBCF92B83D57B2B917E (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// System.Collections.IEnumerator Ricimi.Transition::RunFade(System.String,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Transition_RunFade_mD06625DCF3018A51106284573A7DA1A3E2E88062 (Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* __this, String_t* ___level0, float ___duration1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___fadeColor2, const RuntimeMethod* method) ;
// System.Void Ricimi.Transition/<RunFade>d__5::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeU3Ed__5__ctor_mCDF3EFFE6F70440D9EE3537DA54C1F522B85B739 (U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) ;
// System.Void UnityEngine.GameObject::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject__ctor_m7D0340DE160786E6EFA8DABD39EC3B694DA30AAD (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::SetAsFirstSibling()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_SetAsFirstSibling_mBE0D0E76099F829466DC2FBD71ACFCF3C8EC03BD (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Mathf::InverseLerp(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_InverseLerp_mBD7EC6A7173CE082226077E1557D5BC2D2AE0D9D_inline (float ___a0, float ___b1, float ___value2, const RuntimeMethod* method) ;
// System.Void UnityEngine.SceneManagement.SceneManager::LoadScene(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneManager_LoadScene_mBB3DBC1601A21F8F4E8A5D68FED30EA9412F218E (String_t* ___sceneName0, const RuntimeMethod* method) ;
// System.Single UnityEngine.Mathf::Clamp01(System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline (float ___value0, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Touch::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Start_mFA1FE0C87AA258050AE1731C2A64930353ADF08B (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	{
		// Reset();
		Touch_Reset_mCAD881CB2B776D9F0C8FB5F661D89B8A1E306908(__this, NULL);
		// }
		return;
	}
}
// System.Void Touch::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Update_mD9E2C833301D4E7A90181BC537F64577795474F8 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	{
		// if (Input.GetMouseButtonDown(0))
		bool L_0;
		L_0 = Input_GetMouseButtonDown_m8DFC792D15FFF15D311614D5CC6C5D055E5A1DE3(0, NULL);
		if (!L_0)
		{
			goto IL_0033;
		}
	}
	{
		// position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_2 = L_1.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3;
		L_3 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_4 = L_3.___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_5;
		memset((&L_5), 0, sizeof(L_5));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_5), L_2, L_4, /*hidden argument*/NULL);
		__this->___position_11 = L_5;
		// StartPosition = position;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_6 = __this->___position_11;
		__this->___StartPosition_9 = L_6;
	}

IL_0033:
	{
		// if (Input.GetMouseButton(0))
		bool L_7;
		L_7 = Input_GetMouseButton_m4995DD4A2D4F916565C1B1B5AAF7DF17C126B3EA(0, NULL);
		if (!L_7)
		{
			goto IL_00d7;
		}
	}
	{
		// if (!(Input.mousePosition.x - position.x > -25 && Input.mousePosition.x - position.x < 25) || !(Input.mousePosition.y - position.y > -25 && Input.mousePosition.y - position.y < 25)) // ???? ??? ???? ?? ?? ?? ??
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8;
		L_8 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_9 = L_8.___x_2;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_10 = (&__this->___position_11);
		float L_11 = L_10->___x_0;
		if ((!(((float)((float)il2cpp_codegen_subtract(L_9, L_11))) > ((float)(-25.0f)))))
		{
			goto IL_00b2;
		}
	}
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		L_12 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_13 = L_12.___x_2;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_14 = (&__this->___position_11);
		float L_15 = L_14->___x_0;
		if ((!(((float)((float)il2cpp_codegen_subtract(L_13, L_15))) < ((float)(25.0f)))))
		{
			goto IL_00b2;
		}
	}
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_17 = L_16.___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_18 = (&__this->___position_11);
		float L_19 = L_18->___y_1;
		if ((!(((float)((float)il2cpp_codegen_subtract(L_17, L_19))) > ((float)(-25.0f)))))
		{
			goto IL_00b2;
		}
	}
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_21 = L_20.___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* L_22 = (&__this->___position_11);
		float L_23 = L_22->___y_1;
		if ((((float)((float)il2cpp_codegen_subtract(L_21, L_23))) < ((float)(25.0f))))
		{
			goto IL_00d7;
		}
	}

IL_00b2:
	{
		// DegreeCheck();
		Touch_DegreeCheck_mC5F846CA4B25BEF05C9575530B32F5395B7710B7(__this, NULL);
		// position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		L_24 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_25 = L_24.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_26;
		L_26 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_27 = L_26.___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_28;
		memset((&L_28), 0, sizeof(L_28));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_28), L_25, L_27, /*hidden argument*/NULL);
		__this->___position_11 = L_28;
	}

IL_00d7:
	{
		// if (Input.GetMouseButtonUp(0))
		bool L_29;
		L_29 = Input_GetMouseButtonUp_mBE89CC9C69BBEA9A863819E77EA54411B0476ED6(0, NULL);
		if (!L_29)
		{
			goto IL_010a;
		}
	}
	{
		// LastPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30;
		L_30 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_31 = L_30.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32;
		L_32 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_33 = L_32.___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_34;
		memset((&L_34), 0, sizeof(L_34));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_34), L_31, L_33, /*hidden argument*/NULL);
		__this->___LastPosition_10 = L_34;
		// GestureRecognize();
		Touch_GestureRecognize_m8A8CB7AE4B20D249C809CED60651CCE7A0A6572F(__this, NULL);
		// Reset();
		Touch_Reset_mCAD881CB2B776D9F0C8FB5F661D89B8A1E306908(__this, NULL);
	}

IL_010a:
	{
		// }
		return;
	}
}
// System.Void Touch::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Reset_mCAD881CB2B776D9F0C8FB5F661D89B8A1E306908 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	{
		// direction = 0;
		__this->___direction_8 = 0;
		// index = 0;
		__this->___index_7 = 0;
		// }
		return;
	}
}
// System.Void Touch::DegreeCheck()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_DegreeCheck_mC5F846CA4B25BEF05C9575530B32F5395B7710B7 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	float V_1 = 0.0f;
	{
		// Vector2 v = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - position;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0;
		L_0 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Input_get_mousePosition_mFF21FBD2647DAE2A23BD4C45571CA95D05A0A42C(NULL);
		float L_3 = L_2.___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4;
		memset((&L_4), 0, sizeof(L_4));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_4), L_1, L_3, /*hidden argument*/NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_5 = __this->___position_11;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_6;
		L_6 = Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline(L_4, L_5, NULL);
		V_0 = L_6;
		// float Atan2s = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg + 180;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_7 = V_0;
		float L_8 = L_7.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_9 = V_0;
		float L_10 = L_9.___x_0;
		float L_11;
		L_11 = atan2f(L_8, L_10);
		V_1 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_11, (57.2957802f))), (180.0f)));
		// if (Atan2s <= 315 - 22.5f && Atan2s > 270 - 22.5f)
		float L_12 = V_1;
		if ((!(((float)L_12) <= ((float)(292.5f)))))
		{
			goto IL_005f;
		}
	}
	{
		float L_13 = V_1;
		if ((!(((float)L_13) > ((float)(247.5f)))))
		{
			goto IL_005f;
		}
	}
	{
		// direction = Direction.leftup;
		__this->___direction_8 = 1;
		goto IL_0122;
	}

IL_005f:
	{
		// else if (Atan2s <= 270 - 22.5f && Atan2s > 225 - 22.5f)
		float L_14 = V_1;
		if ((!(((float)L_14) <= ((float)(247.5f)))))
		{
			goto IL_007b;
		}
	}
	{
		float L_15 = V_1;
		if ((!(((float)L_15) > ((float)(202.5f)))))
		{
			goto IL_007b;
		}
	}
	{
		// direction = Direction.up;
		__this->___direction_8 = 2;
		goto IL_0122;
	}

IL_007b:
	{
		// else if (Atan2s <= 225 - 22.5f && Atan2s > 180 - 22.5f)
		float L_16 = V_1;
		if ((!(((float)L_16) <= ((float)(202.5f)))))
		{
			goto IL_0097;
		}
	}
	{
		float L_17 = V_1;
		if ((!(((float)L_17) > ((float)(157.5f)))))
		{
			goto IL_0097;
		}
	}
	{
		// direction = Direction.rightup;
		__this->___direction_8 = 3;
		goto IL_0122;
	}

IL_0097:
	{
		// else if (Atan2s < 180 - 22.5f && Atan2s > 135 - 22.5f)
		float L_18 = V_1;
		if ((!(((float)L_18) < ((float)(157.5f)))))
		{
			goto IL_00b0;
		}
	}
	{
		float L_19 = V_1;
		if ((!(((float)L_19) > ((float)(112.5f)))))
		{
			goto IL_00b0;
		}
	}
	{
		// direction = Direction.right;
		__this->___direction_8 = 4;
		goto IL_0122;
	}

IL_00b0:
	{
		// else if (Atan2s <= 135 - 22.5f && Atan2s > 90 - 22.5f)
		float L_20 = V_1;
		if ((!(((float)L_20) <= ((float)(112.5f)))))
		{
			goto IL_00c9;
		}
	}
	{
		float L_21 = V_1;
		if ((!(((float)L_21) > ((float)(67.5f)))))
		{
			goto IL_00c9;
		}
	}
	{
		// direction = Direction.rightdown;
		__this->___direction_8 = 5;
		goto IL_0122;
	}

IL_00c9:
	{
		// else if (Atan2s <= 90 - 22.5f && Atan2s > 45 - 22.5f)
		float L_22 = V_1;
		if ((!(((float)L_22) <= ((float)(67.5f)))))
		{
			goto IL_00e2;
		}
	}
	{
		float L_23 = V_1;
		if ((!(((float)L_23) > ((float)(22.5f)))))
		{
			goto IL_00e2;
		}
	}
	{
		// direction = Direction.down;
		__this->___direction_8 = 6;
		goto IL_0122;
	}

IL_00e2:
	{
		// else if ((Atan2s >= 0 && Atan2s <= 22.5f) || (Atan2s > 337.5f && Atan2s < 360))
		float L_24 = V_1;
		if ((!(((float)L_24) >= ((float)(0.0f)))))
		{
			goto IL_00f2;
		}
	}
	{
		float L_25 = V_1;
		if ((((float)L_25) <= ((float)(22.5f))))
		{
			goto IL_0102;
		}
	}

IL_00f2:
	{
		float L_26 = V_1;
		if ((!(((float)L_26) > ((float)(337.5f)))))
		{
			goto IL_010b;
		}
	}
	{
		float L_27 = V_1;
		if ((!(((float)L_27) < ((float)(360.0f)))))
		{
			goto IL_010b;
		}
	}

IL_0102:
	{
		// direction = Direction.leftdown;
		__this->___direction_8 = 7;
		goto IL_0122;
	}

IL_010b:
	{
		// else if (Atan2s <= 337.5f && Atan2s > 315 - 22.5f)
		float L_28 = V_1;
		if ((!(((float)L_28) <= ((float)(337.5f)))))
		{
			goto IL_0122;
		}
	}
	{
		float L_29 = V_1;
		if ((!(((float)L_29) > ((float)(292.5f)))))
		{
			goto IL_0122;
		}
	}
	{
		// direction = Direction.left;
		__this->___direction_8 = 8;
	}

IL_0122:
	{
		// if (vals[index] != (int)direction)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_30 = __this->___vals_6;
		int32_t L_31 = __this->___index_7;
		NullCheck(L_30);
		int32_t L_32 = L_31;
		int32_t L_33 = (L_30)->GetAt(static_cast<il2cpp_array_size_t>(L_32));
		int32_t L_34 = __this->___direction_8;
		if ((((int32_t)L_33) == ((int32_t)L_34)))
		{
			goto IL_016e;
		}
	}
	{
		// if (direction != 0)
		int32_t L_35 = __this->___direction_8;
		if (!L_35)
		{
			goto IL_016e;
		}
	}
	{
		// index++;
		int32_t L_36 = __this->___index_7;
		__this->___index_7 = ((int32_t)il2cpp_codegen_add(L_36, 1));
		// vals[index] = (int)direction;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_37 = __this->___vals_6;
		int32_t L_38 = __this->___index_7;
		int32_t L_39 = __this->___direction_8;
		NullCheck(L_37);
		(L_37)->SetAt(static_cast<il2cpp_array_size_t>(L_38), (int32_t)L_39);
		// degree[index] = Atan2s;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_40 = __this->___degree_5;
		int32_t L_41 = __this->___index_7;
		float L_42 = V_1;
		NullCheck(L_40);
		(L_40)->SetAt(static_cast<il2cpp_array_size_t>(L_41), (float)L_42);
	}

IL_016e:
	{
		// }
		return;
	}
}
// System.Void Touch::StraightLine_Check()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_StraightLine_Check_mC2B42F2818D3B2DB4607C0671E44B8A1629E2A59 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4D5F60EE1CF72404BFE4275C2F2246B6496A2207);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5FCDDC1467FCECED756A40E50069F3AB7F63BFB4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral89C5316A8C5B56F49BBC3872ADAA752D43808D2F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB4682038889D880775C9BFAA4A7B79D3F99829CC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCA24A9346B673E2A6B3B521D7CAE3C735390E49B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE383D87043E9C13D6699C11A033A799887F9CB9F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEE1FCAC446340AFD25CB10F3EE5EB58C946BBCF0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF349388D8BE15C1163C52DD0658C0609DE349B15);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		// if (index == 2)
		int32_t L_0 = __this->___index_7;
		if ((!(((uint32_t)L_0) == ((uint32_t)2))))
		{
			goto IL_0071;
		}
	}
	{
		// if (vals[0] - vals[1] == 1 || vals[0] - vals[1] == -1)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = __this->___vals_6;
		NullCheck(L_1);
		int32_t L_2 = 0;
		int32_t L_3 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = __this->___vals_6;
		NullCheck(L_4);
		int32_t L_5 = 1;
		int32_t L_6 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		if ((((int32_t)((int32_t)il2cpp_codegen_subtract(L_3, L_6))) == ((int32_t)1)))
		{
			goto IL_0031;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_7 = __this->___vals_6;
		NullCheck(L_7);
		int32_t L_8 = 0;
		int32_t L_9 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_10 = __this->___vals_6;
		NullCheck(L_10);
		int32_t L_11 = 1;
		int32_t L_12 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		if ((!(((uint32_t)((int32_t)il2cpp_codegen_subtract(L_9, L_12))) == ((uint32_t)(-1)))))
		{
			goto IL_0071;
		}
	}

IL_0031:
	{
		// if (degree[0] - degree[1] > -30)
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_13 = __this->___degree_5;
		NullCheck(L_13);
		int32_t L_14 = 0;
		float L_15 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_16 = __this->___degree_5;
		NullCheck(L_16);
		int32_t L_17 = 1;
		float L_18 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		if ((!(((float)((float)il2cpp_codegen_subtract(L_15, L_18))) > ((float)(-30.0f)))))
		{
			goto IL_0052;
		}
	}
	{
		// index = 1;
		__this->___index_7 = 1;
		goto IL_0071;
	}

IL_0052:
	{
		// else if (degree[0] - degree[1] < 30)
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_19 = __this->___degree_5;
		NullCheck(L_19);
		int32_t L_20 = 0;
		float L_21 = (L_19)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_22 = __this->___degree_5;
		NullCheck(L_22);
		int32_t L_23 = 1;
		float L_24 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		if ((!(((float)((float)il2cpp_codegen_subtract(L_21, L_24))) < ((float)(30.0f)))))
		{
			goto IL_0071;
		}
	}
	{
		// index = 1;
		__this->___index_7 = 1;
	}

IL_0071:
	{
		// if (index == 1)
		int32_t L_25 = __this->___index_7;
		if ((!(((uint32_t)L_25) == ((uint32_t)1))))
		{
			goto IL_013e;
		}
	}
	{
		// switch (vals[1])
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_26 = __this->___vals_6;
		NullCheck(L_26);
		int32_t L_27 = 1;
		int32_t L_28 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_27));
		V_0 = L_28;
		int32_t L_29 = V_0;
		switch (((int32_t)il2cpp_codegen_subtract(L_29, 1)))
		{
			case 0:
			{
				goto IL_00af;
			}
			case 1:
			{
				goto IL_00c1;
			}
			case 2:
			{
				goto IL_00d3;
			}
			case 3:
			{
				goto IL_00e5;
			}
			case 4:
			{
				goto IL_00f7;
			}
			case 5:
			{
				goto IL_0109;
			}
			case 6:
			{
				goto IL_011b;
			}
			case 7:
			{
				goto IL_012d;
			}
		}
	}
	{
		return;
	}

IL_00af:
	{
		// Debug.Log("?? ???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteralB4682038889D880775C9BFAA4A7B79D3F99829CC, NULL);
		// result = Result.up;
		__this->___result_4 = 1;
		// break;
		return;
	}

IL_00c1:
	{
		// Debug.Log("??? ?? ?? ???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteralCA24A9346B673E2A6B3B521D7CAE3C735390E49B, NULL);
		// result = Result.rightup;
		__this->___result_4 = 2;
		// break;
		return;
	}

IL_00d3:
	{
		// Debug.Log("????? ???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteralF349388D8BE15C1163C52DD0658C0609DE349B15, NULL);
		// result = Result.right;
		__this->___result_4 = 3;
		// break;
		return;
	}

IL_00e5:
	{
		// Debug.Log("??? ??? ?? ???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral5FCDDC1467FCECED756A40E50069F3AB7F63BFB4, NULL);
		// result = Result.rightdown;
		__this->___result_4 = 4;
		// break;
		return;
	}

IL_00f7:
	{
		// Debug.Log("??? ???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral89C5316A8C5B56F49BBC3872ADAA752D43808D2F, NULL);
		// result = Result.down;
		__this->___result_4 = 5;
		// break;
		return;
	}

IL_0109:
	{
		// Debug.Log("?? ??? ?? ???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral4D5F60EE1CF72404BFE4275C2F2246B6496A2207, NULL);
		// result = Result.leftdown;
		__this->___result_4 = 6;
		// break;
		return;
	}

IL_011b:
	{
		// Debug.Log("???? ???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteralE383D87043E9C13D6699C11A033A799887F9CB9F, NULL);
		// result = Result.left;
		__this->___result_4 = 7;
		// break;
		return;
	}

IL_012d:
	{
		// Debug.Log("?? ?? ?? ???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteralEE1FCAC446340AFD25CB10F3EE5EB58C946BBCF0, NULL);
		// result = Result.leftup;
		__this->___result_4 = 0;
	}

IL_013e:
	{
		// }
		return;
	}
}
// System.Void Touch::Circle_Check()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Circle_Check_m56856589F139A25A36EFE690D607E79483CBD8F2 (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral010CF79B276B799D3075D15F60FEA1F42DE0231C);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (index > 6 && index < 10)
		int32_t L_0 = __this->___index_7;
		if ((((int32_t)L_0) <= ((int32_t)6)))
		{
			goto IL_00e2;
		}
	}
	{
		int32_t L_1 = __this->___index_7;
		if ((((int32_t)L_1) >= ((int32_t)((int32_t)10))))
		{
			goto IL_00e2;
		}
	}
	{
		// if (vals[1] == 8) if (vals[2] == 1) if (vals[3] == 2) if (vals[4] == 3) if (vals[5] == 4) if (vals[6] == 5) if (vals[7] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_2 = __this->___vals_6;
		NullCheck(L_2);
		int32_t L_3 = 1;
		int32_t L_4 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		if ((!(((uint32_t)L_4) == ((uint32_t)8))))
		{
			goto IL_0078;
		}
	}
	{
		// if (vals[1] == 8) if (vals[2] == 1) if (vals[3] == 2) if (vals[4] == 3) if (vals[5] == 4) if (vals[6] == 5) if (vals[7] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_5 = __this->___vals_6;
		NullCheck(L_5);
		int32_t L_6 = 2;
		int32_t L_7 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		if ((!(((uint32_t)L_7) == ((uint32_t)1))))
		{
			goto IL_0078;
		}
	}
	{
		// if (vals[1] == 8) if (vals[2] == 1) if (vals[3] == 2) if (vals[4] == 3) if (vals[5] == 4) if (vals[6] == 5) if (vals[7] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_8 = __this->___vals_6;
		NullCheck(L_8);
		int32_t L_9 = 3;
		int32_t L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		if ((!(((uint32_t)L_10) == ((uint32_t)2))))
		{
			goto IL_0078;
		}
	}
	{
		// if (vals[1] == 8) if (vals[2] == 1) if (vals[3] == 2) if (vals[4] == 3) if (vals[5] == 4) if (vals[6] == 5) if (vals[7] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_11 = __this->___vals_6;
		NullCheck(L_11);
		int32_t L_12 = 4;
		int32_t L_13 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		if ((!(((uint32_t)L_13) == ((uint32_t)3))))
		{
			goto IL_0078;
		}
	}
	{
		// if (vals[1] == 8) if (vals[2] == 1) if (vals[3] == 2) if (vals[4] == 3) if (vals[5] == 4) if (vals[6] == 5) if (vals[7] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_14 = __this->___vals_6;
		NullCheck(L_14);
		int32_t L_15 = 5;
		int32_t L_16 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		if ((!(((uint32_t)L_16) == ((uint32_t)4))))
		{
			goto IL_0078;
		}
	}
	{
		// if (vals[1] == 8) if (vals[2] == 1) if (vals[3] == 2) if (vals[4] == 3) if (vals[5] == 4) if (vals[6] == 5) if (vals[7] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_17 = __this->___vals_6;
		NullCheck(L_17);
		int32_t L_18 = 6;
		int32_t L_19 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		if ((!(((uint32_t)L_19) == ((uint32_t)5))))
		{
			goto IL_0078;
		}
	}
	{
		// if (vals[1] == 8) if (vals[2] == 1) if (vals[3] == 2) if (vals[4] == 3) if (vals[5] == 4) if (vals[6] == 5) if (vals[7] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_20 = __this->___vals_6;
		NullCheck(L_20);
		int32_t L_21 = 7;
		int32_t L_22 = (L_20)->GetAt(static_cast<il2cpp_array_size_t>(L_21));
		if ((!(((uint32_t)L_22) == ((uint32_t)6))))
		{
			goto IL_0078;
		}
	}
	{
		// Debug.Log("Circle");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral010CF79B276B799D3075D15F60FEA1F42DE0231C, NULL);
		// result = Result.Circle;
		__this->___result_4 = ((int32_t)10);
	}

IL_0078:
	{
		// if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_23 = __this->___vals_6;
		NullCheck(L_23);
		int32_t L_24 = 1;
		int32_t L_25 = (L_23)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		if ((!(((uint32_t)L_25) == ((uint32_t)7))))
		{
			goto IL_00e2;
		}
	}
	{
		// if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_26 = __this->___vals_6;
		NullCheck(L_26);
		int32_t L_27 = 2;
		int32_t L_28 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_27));
		if ((!(((uint32_t)L_28) == ((uint32_t)8))))
		{
			goto IL_00e2;
		}
	}
	{
		// if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_29 = __this->___vals_6;
		NullCheck(L_29);
		int32_t L_30 = 3;
		int32_t L_31 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		if ((!(((uint32_t)L_31) == ((uint32_t)1))))
		{
			goto IL_00e2;
		}
	}
	{
		// if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_32 = __this->___vals_6;
		NullCheck(L_32);
		int32_t L_33 = 4;
		int32_t L_34 = (L_32)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		if ((!(((uint32_t)L_34) == ((uint32_t)2))))
		{
			goto IL_00e2;
		}
	}
	{
		// if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_35 = __this->___vals_6;
		NullCheck(L_35);
		int32_t L_36 = 5;
		int32_t L_37 = (L_35)->GetAt(static_cast<il2cpp_array_size_t>(L_36));
		if ((!(((uint32_t)L_37) == ((uint32_t)3))))
		{
			goto IL_00e2;
		}
	}
	{
		// if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_38 = __this->___vals_6;
		NullCheck(L_38);
		int32_t L_39 = 6;
		int32_t L_40 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		if ((!(((uint32_t)L_40) == ((uint32_t)4))))
		{
			goto IL_00e2;
		}
	}
	{
		// if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_41 = __this->___vals_6;
		NullCheck(L_41);
		int32_t L_42 = 7;
		int32_t L_43 = (L_41)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		if ((!(((uint32_t)L_43) == ((uint32_t)5))))
		{
			goto IL_00e2;
		}
	}
	{
		// if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_44 = __this->___vals_6;
		NullCheck(L_44);
		int32_t L_45 = 8;
		int32_t L_46 = (L_44)->GetAt(static_cast<il2cpp_array_size_t>(L_45));
		if ((!(((uint32_t)L_46) == ((uint32_t)6))))
		{
			goto IL_00e2;
		}
	}
	{
		// Debug.Log("Circle");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral010CF79B276B799D3075D15F60FEA1F42DE0231C, NULL);
		// result = Result.Circle;
		__this->___result_4 = ((int32_t)10);
	}

IL_00e2:
	{
		// }
		return;
	}
}
// System.Void Touch::Z_Check()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Z_Check_m429AB8C41A323515BF7229D012061C11A3178B1F (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral234D19ACC97DBDDB4C2351D9B583DDC8AD958380);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (index < 5)
		int32_t L_0 = __this->___index_7;
		if ((((int32_t)L_0) >= ((int32_t)5)))
		{
			goto IL_007a;
		}
	}
	{
		// if (vals[1] == 3)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = __this->___vals_6;
		NullCheck(L_1);
		int32_t L_2 = 1;
		int32_t L_3 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		if ((!(((uint32_t)L_3) == ((uint32_t)3))))
		{
			goto IL_007a;
		}
	}
	{
		// if (vals[2] == 5 || vals[2] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = __this->___vals_6;
		NullCheck(L_4);
		int32_t L_5 = 2;
		int32_t L_6 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		if ((((int32_t)L_6) == ((int32_t)5)))
		{
			goto IL_002a;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_7 = __this->___vals_6;
		NullCheck(L_7);
		int32_t L_8 = 2;
		int32_t L_9 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		if ((!(((uint32_t)L_9) == ((uint32_t)6))))
		{
			goto IL_007a;
		}
	}

IL_002a:
	{
		// if (vals[3] == 6 || vals[3] == 5) if (vals[4] == 3) Debug.Log("Z"); result = Result.Z;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_10 = __this->___vals_6;
		NullCheck(L_10);
		int32_t L_11 = 3;
		int32_t L_12 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		if ((((int32_t)L_12) == ((int32_t)6)))
		{
			goto IL_0040;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_13 = __this->___vals_6;
		NullCheck(L_13);
		int32_t L_14 = 3;
		int32_t L_15 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		if ((!(((uint32_t)L_15) == ((uint32_t)5))))
		{
			goto IL_0055;
		}
	}

IL_0040:
	{
		// if (vals[3] == 6 || vals[3] == 5) if (vals[4] == 3) Debug.Log("Z"); result = Result.Z;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_16 = __this->___vals_6;
		NullCheck(L_16);
		int32_t L_17 = 4;
		int32_t L_18 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		if ((!(((uint32_t)L_18) == ((uint32_t)3))))
		{
			goto IL_0055;
		}
	}
	{
		// if (vals[3] == 6 || vals[3] == 5) if (vals[4] == 3) Debug.Log("Z"); result = Result.Z;
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral234D19ACC97DBDDB4C2351D9B583DDC8AD958380, NULL);
	}

IL_0055:
	{
		// if (vals[3] == 6 || vals[3] == 5) if (vals[4] == 3) Debug.Log("Z"); result = Result.Z;
		__this->___result_4 = ((int32_t)12);
		// if (vals[3] == 3) Debug.Log("Z"); result = Result.Z;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_19 = __this->___vals_6;
		NullCheck(L_19);
		int32_t L_20 = 3;
		int32_t L_21 = (L_19)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		if ((!(((uint32_t)L_21) == ((uint32_t)3))))
		{
			goto IL_0072;
		}
	}
	{
		// if (vals[3] == 3) Debug.Log("Z"); result = Result.Z;
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral234D19ACC97DBDDB4C2351D9B583DDC8AD958380, NULL);
	}

IL_0072:
	{
		// if (vals[3] == 3) Debug.Log("Z"); result = Result.Z;
		__this->___result_4 = ((int32_t)12);
	}

IL_007a:
	{
		// }
		return;
	}
}
// System.Void Touch::Triangle_Check()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_Triangle_Check_m8C7D33EA6A5C13ADFD7F0DB8D34BCF91190442BD (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4C07E7B7967064E6CE8D573509183B7F8A0A42C2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6C858B704FEF0D525710D559CD932694EF007F75);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral764C47C904EA835A2474591FF7FEA8354BBD2829);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		// if (index <= 5)
		int32_t L_0 = __this->___index_7;
		if ((((int32_t)L_0) > ((int32_t)5)))
		{
			goto IL_0128;
		}
	}
	{
		// if (vals[1] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = __this->___vals_6;
		NullCheck(L_1);
		int32_t L_2 = 1;
		int32_t L_3 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		if ((!(((uint32_t)L_3) == ((uint32_t)6))))
		{
			goto IL_0057;
		}
	}
	{
		// for (int i = 2; i <= index - 1; i++)
		V_0 = 2;
		goto IL_004b;
	}

IL_001b:
	{
		// if (vals[i] == 3)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = __this->___vals_6;
		int32_t L_5 = V_0;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		int32_t L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		if ((!(((uint32_t)L_7) == ((uint32_t)3))))
		{
			goto IL_0047;
		}
	}
	{
		// if (vals[index] == 8)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_8 = __this->___vals_6;
		int32_t L_9 = __this->___index_7;
		NullCheck(L_8);
		int32_t L_10 = L_9;
		int32_t L_11 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		if ((!(((uint32_t)L_11) == ((uint32_t)8))))
		{
			goto IL_0047;
		}
	}
	{
		// Debug.Log("???");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral6C858B704FEF0D525710D559CD932694EF007F75, NULL);
		// result = Result.triangle1;
		__this->___result_4 = 8;
	}

IL_0047:
	{
		// for (int i = 2; i <= index - 1; i++)
		int32_t L_12 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_004b:
	{
		// for (int i = 2; i <= index - 1; i++)
		int32_t L_13 = V_0;
		int32_t L_14 = __this->___index_7;
		if ((((int32_t)L_13) <= ((int32_t)((int32_t)il2cpp_codegen_subtract(L_14, 1)))))
		{
			goto IL_001b;
		}
	}
	{
		return;
	}

IL_0057:
	{
		// else if (vals[1] == 3)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_15 = __this->___vals_6;
		NullCheck(L_15);
		int32_t L_16 = 1;
		int32_t L_17 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
		if ((!(((uint32_t)L_17) == ((uint32_t)3))))
		{
			goto IL_00c0;
		}
	}
	{
		// for (int i = 2; i <= 4; i++)
		V_1 = 2;
		goto IL_00bb;
	}

IL_0066:
	{
		// if (vals[i] == 6)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_18 = __this->___vals_6;
		int32_t L_19 = V_1;
		NullCheck(L_18);
		int32_t L_20 = L_19;
		int32_t L_21 = (L_18)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		if ((!(((uint32_t)L_21) == ((uint32_t)6))))
		{
			goto IL_00b7;
		}
	}
	{
		// if (vals[index] == 8)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_22 = __this->___vals_6;
		int32_t L_23 = __this->___index_7;
		NullCheck(L_22);
		int32_t L_24 = L_23;
		int32_t L_25 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		if ((!(((uint32_t)L_25) == ((uint32_t)8))))
		{
			goto IL_0095;
		}
	}
	{
		// Debug.Log("? ??? 1");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral4C07E7B7967064E6CE8D573509183B7F8A0A42C2, NULL);
		// result = Result.triangle2;
		__this->___result_4 = ((int32_t)9);
		goto IL_00b7;
	}

IL_0095:
	{
		// else if (vals[index] == 1)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_26 = __this->___vals_6;
		int32_t L_27 = __this->___index_7;
		NullCheck(L_26);
		int32_t L_28 = L_27;
		int32_t L_29 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_28));
		if ((!(((uint32_t)L_29) == ((uint32_t)1))))
		{
			goto IL_00b7;
		}
	}
	{
		// Debug.Log("? ??? 1");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral4C07E7B7967064E6CE8D573509183B7F8A0A42C2, NULL);
		// result = Result.triangle2;
		__this->___result_4 = ((int32_t)9);
	}

IL_00b7:
	{
		// for (int i = 2; i <= 4; i++)
		int32_t L_30 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_30, 1));
	}

IL_00bb:
	{
		// for (int i = 2; i <= 4; i++)
		int32_t L_31 = V_1;
		if ((((int32_t)L_31) <= ((int32_t)4)))
		{
			goto IL_0066;
		}
	}
	{
		return;
	}

IL_00c0:
	{
		// else if (vals[1] == 7)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_32 = __this->___vals_6;
		NullCheck(L_32);
		int32_t L_33 = 1;
		int32_t L_34 = (L_32)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		if ((!(((uint32_t)L_34) == ((uint32_t)7))))
		{
			goto IL_0128;
		}
	}
	{
		// for (int i = 2; i <= 4; i++)
		V_2 = 2;
		goto IL_0124;
	}

IL_00cf:
	{
		// if (vals[i] == 4)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_35 = __this->___vals_6;
		int32_t L_36 = V_2;
		NullCheck(L_35);
		int32_t L_37 = L_36;
		int32_t L_38 = (L_35)->GetAt(static_cast<il2cpp_array_size_t>(L_37));
		if ((!(((uint32_t)L_38) == ((uint32_t)4))))
		{
			goto IL_0120;
		}
	}
	{
		// if (vals[index] == 2)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_39 = __this->___vals_6;
		int32_t L_40 = __this->___index_7;
		NullCheck(L_39);
		int32_t L_41 = L_40;
		int32_t L_42 = (L_39)->GetAt(static_cast<il2cpp_array_size_t>(L_41));
		if ((!(((uint32_t)L_42) == ((uint32_t)2))))
		{
			goto IL_00fe;
		}
	}
	{
		// Debug.Log("? ??? 2");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral764C47C904EA835A2474591FF7FEA8354BBD2829, NULL);
		// result = Result.triangle2;
		__this->___result_4 = ((int32_t)9);
		goto IL_0120;
	}

IL_00fe:
	{
		// else if (vals[index] == 1)
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_43 = __this->___vals_6;
		int32_t L_44 = __this->___index_7;
		NullCheck(L_43);
		int32_t L_45 = L_44;
		int32_t L_46 = (L_43)->GetAt(static_cast<il2cpp_array_size_t>(L_45));
		if ((!(((uint32_t)L_46) == ((uint32_t)1))))
		{
			goto IL_0120;
		}
	}
	{
		// Debug.Log("? ??? 2");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(_stringLiteral764C47C904EA835A2474591FF7FEA8354BBD2829, NULL);
		// result = Result.triangle2;
		__this->___result_4 = ((int32_t)9);
	}

IL_0120:
	{
		// for (int i = 2; i <= 4; i++)
		int32_t L_47 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_47, 1));
	}

IL_0124:
	{
		// for (int i = 2; i <= 4; i++)
		int32_t L_48 = V_2;
		if ((((int32_t)L_48) <= ((int32_t)4)))
		{
			goto IL_00cf;
		}
	}

IL_0128:
	{
		// }
		return;
	}
}
// System.Void Touch::GestureRecognize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch_GestureRecognize_m8A8CB7AE4B20D249C809CED60651CCE7A0A6572F (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	{
		// Triangle_Check();
		Touch_Triangle_Check_m8C7D33EA6A5C13ADFD7F0DB8D34BCF91190442BD(__this, NULL);
		// StraightLine_Check();
		Touch_StraightLine_Check_mC2B42F2818D3B2DB4607C0671E44B8A1629E2A59(__this, NULL);
		// Circle_Check();
		Touch_Circle_Check_m56856589F139A25A36EFE690D607E79483CBD8F2(__this, NULL);
		// Z_Check();
		Touch_Z_Check_m429AB8C41A323515BF7229D012061C11A3178B1F(__this, NULL);
		// }
		return;
	}
}
// System.Void Touch::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Touch__ctor_mF116F191559A62D3742652AB8482AF28825D95DD (Touch_t7EAB8D5B909B844F3E35764114EF5B8260CE55F5* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public Result result = Result.none;
		__this->___result_4 = ((int32_t)13);
		// float[] degree = new float[50];          // ??
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_0 = (SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)SZArrayNew(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)50));
		__this->___degree_5 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___degree_5), (void*)L_0);
		// int[] vals = new int[250];               // ??
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)250));
		__this->___vals_6 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___vals_6), (void*)L_1);
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.AnimatedButton::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatedButton_Start_m49EF1010F9053E3DCBFDFEE670A55C7D8EBE4BFB (AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_m1C9FCB4BBE56BEC6BDEF6E4BA1E5DFF91614D7CE_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// base.Start();
		UIBehaviour_Start_mB12643ED6D859CD3682B4BF5B9CA7F72E8A72B45(__this, NULL);
		// m_animator = GetComponent<Animator>();
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_0;
		L_0 = Component_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_m1C9FCB4BBE56BEC6BDEF6E4BA1E5DFF91614D7CE(__this, Component_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_m1C9FCB4BBE56BEC6BDEF6E4BA1E5DFF91614D7CE_RuntimeMethod_var);
		__this->___m_animator_6 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_animator_6), (void*)L_0);
		// }
		return;
	}
}
// Ricimi.AnimatedButton/ButtonClickedEvent Ricimi.AnimatedButton::get_onClick()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* AnimatedButton_get_onClick_mEFCF8D19BAA1CBF8FA8B3035AAFA336E995738E0 (AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* __this, const RuntimeMethod* method) 
{
	{
		// get { return m_OnClick; }
		ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* L_0 = __this->___m_OnClick_5;
		return L_0;
	}
}
// System.Void Ricimi.AnimatedButton::set_onClick(Ricimi.AnimatedButton/ButtonClickedEvent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatedButton_set_onClick_mEE9E8B32C24B9BC413B1F632B61A7BA7294C0C87 (AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* __this, ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* ___value0, const RuntimeMethod* method) 
{
	{
		// set { m_OnClick = value; }
		ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* L_0 = ___value0;
		__this->___m_OnClick_5 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_OnClick_5), (void*)L_0);
		// set { m_OnClick = value; }
		return;
	}
}
// System.Void Ricimi.AnimatedButton::OnPointerDown(UnityEngine.EventSystems.PointerEventData)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatedButton_OnPointerDown_m8816384897BBDF6D87BD57F3A7358295D640DE49 (AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* __this, PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* ___eventData0, const RuntimeMethod* method) 
{
	{
		// if (eventData.button != PointerEventData.InputButton.Left || !interactable)
		PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* L_0 = ___eventData0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = PointerEventData_get_button_mA8CBDAF2E16927E6952BC60040D56630BCC95B0B_inline(L_0, NULL);
		if (L_1)
		{
			goto IL_0010;
		}
	}
	{
		bool L_2 = __this->___interactable_4;
		if (L_2)
		{
			goto IL_0011;
		}
	}

IL_0010:
	{
		// return;
		return;
	}

IL_0011:
	{
		// Press();
		AnimatedButton_Press_m4A7A582EDEEA373B0BB82D13EE71DD7821F42578(__this, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.AnimatedButton::Press()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatedButton_Press_m4A7A582EDEEA373B0BB82D13EE71DD7821F42578 (AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral058B00E75A4248FD43D00FBBE466461FE0E26422);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral461E3E44AE80BC4E861DB32ED3691F004543C3A2);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (!IsActive())
		bool L_0;
		L_0 = VirtualFuncInvoker0< bool >::Invoke(9 /* System.Boolean UnityEngine.EventSystems.UIBehaviour::IsActive() */, __this);
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// m_animator.SetTrigger("Pressed");
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_1 = __this->___m_animator_6;
		NullCheck(L_1);
		Animator_SetTrigger_mC9CD54D627C8843EF6E159E167449D216EF6EB30(L_1, _stringLiteral461E3E44AE80BC4E861DB32ED3691F004543C3A2, NULL);
		// Invoke("InvokeOnClickAction", 0.1f);
		MonoBehaviour_Invoke_mF724350C59362B0F1BFE26383209A274A29A63FB(__this, _stringLiteral058B00E75A4248FD43D00FBBE466461FE0E26422, (0.100000001f), NULL);
		// }
		return;
	}
}
// System.Void Ricimi.AnimatedButton::InvokeOnClickAction()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatedButton_InvokeOnClickAction_m8DEAA1079691D15631450EE2C0A5993D7BAB6AD8 (AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* __this, const RuntimeMethod* method) 
{
	{
		// m_OnClick.Invoke();
		ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* L_0 = __this->___m_OnClick_5;
		NullCheck(L_0);
		UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2(L_0, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.AnimatedButton::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatedButton__ctor_m5660C943857EFE6DD336232F0AB488850F591678 (AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public bool interactable = true;
		__this->___interactable_4 = (bool)1;
		// private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();
		ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* L_0 = (ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8*)il2cpp_codegen_object_new(ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		ButtonClickedEvent__ctor_mFB69F67184B04E2D2466B0693DABF728823F7C8D(L_0, NULL);
		__this->___m_OnClick_5 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_OnClick_5), (void*)L_0);
		UIBehaviour__ctor_m24C66A65DDD996E779871C6655CF11B871F11337(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.AnimatedButton/ButtonClickedEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonClickedEvent__ctor_mFB69F67184B04E2D2466B0693DABF728823F7C8D (ButtonClickedEvent_t91D41485FF80D8C9C1640790631438F496A691C8* __this, const RuntimeMethod* method) 
{
	{
		UnityEvent__ctor_m03D3E5121B9A6100351984D0CE3050B909CD3235(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.BackgroundMusic::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BackgroundMusic_Start_m571C649164A11197A16CF0A07EFBDD732D9A5A61 (BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m42DA4DEA19EB60D80CBED7413ADEB27FA033C77B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (Instance != null)
		BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* L_0 = ((BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_StaticFields*)il2cpp_codegen_static_fields_for(BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_il2cpp_TypeInfo_var))->___Instance_4;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		// DestroyImmediate(gameObject);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_2;
		L_2 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_DestroyImmediate_m6336EBC83591A5DB64EC70C92132824C6E258705(L_2, NULL);
		return;
	}

IL_0019:
	{
		// DontDestroyOnLoad(gameObject);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3;
		L_3 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_DontDestroyOnLoad_m4B70C3AEF886C176543D1295507B6455C9DCAEA7(L_3, NULL);
		// Instance = this;
		((BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_StaticFields*)il2cpp_codegen_static_fields_for(BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_il2cpp_TypeInfo_var))->___Instance_4 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&((BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_StaticFields*)il2cpp_codegen_static_fields_for(BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_il2cpp_TypeInfo_var))->___Instance_4), (void*)__this);
		// m_audioSource = GetComponent<AudioSource>();
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_4;
		L_4 = Component_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m42DA4DEA19EB60D80CBED7413ADEB27FA033C77B(__this, Component_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m42DA4DEA19EB60D80CBED7413ADEB27FA033C77B_RuntimeMethod_var);
		__this->___m_audioSource_5 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_audioSource_5), (void*)L_4);
		// m_audioSource.ignoreListenerVolume = true;
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_5 = __this->___m_audioSource_5;
		NullCheck(L_5);
		AudioSource_set_ignoreListenerVolume_mAB973FFB2B666C4C6DE3BF34C930C28CC315731D(L_5, (bool)1, NULL);
		// m_audioSource.volume = PlayerPrefs.GetInt("music_on");
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_6 = __this->___m_audioSource_5;
		int32_t L_7;
		L_7 = PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987(_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E, NULL);
		NullCheck(L_6);
		AudioSource_set_volume_mD902BBDBBDE0E3C148609BF3C05096148E90F2C0(L_6, ((float)L_7), NULL);
		// AudioListener.volume = PlayerPrefs.GetInt("sound_on");
		int32_t L_8;
		L_8 = PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987(_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD, NULL);
		AudioListener_set_volume_m72BAF2D558A5449091A59630EBF48095DEB4C721(((float)L_8), NULL);
		// }
		return;
	}
}
// System.Void Ricimi.BackgroundMusic::FadeIn()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BackgroundMusic_FadeIn_mB5A32B16E2569C9A0B591BF14E5063DC1C2BD859 (BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (PlayerPrefs.GetInt("music_on") == 1)
		int32_t L_0;
		L_0 = PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987(_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E, NULL);
		if ((!(((uint32_t)L_0) == ((uint32_t)1))))
		{
			goto IL_0020;
		}
	}
	{
		// StartCoroutine(FadeAudio(1.0f, Fade.In));
		RuntimeObject* L_1;
		L_1 = BackgroundMusic_FadeAudio_mD7398B28240D708B158C36E048E4841A73E62C85(__this, (1.0f), 0, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_2;
		L_2 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_1, NULL);
	}

IL_0020:
	{
		// }
		return;
	}
}
// System.Void Ricimi.BackgroundMusic::FadeOut()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BackgroundMusic_FadeOut_m370AC979E7010F5A1209574DEFD5C0A34F3494B0 (BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (PlayerPrefs.GetInt("music_on") == 1)
		int32_t L_0;
		L_0 = PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987(_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E, NULL);
		if ((!(((uint32_t)L_0) == ((uint32_t)1))))
		{
			goto IL_0020;
		}
	}
	{
		// StartCoroutine(FadeAudio(1.0f, Fade.Out));
		RuntimeObject* L_1;
		L_1 = BackgroundMusic_FadeAudio_mD7398B28240D708B158C36E048E4841A73E62C85(__this, (1.0f), 1, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_2;
		L_2 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_1, NULL);
	}

IL_0020:
	{
		// }
		return;
	}
}
// System.Collections.IEnumerator Ricimi.BackgroundMusic::FadeAudio(System.Single,Ricimi.BackgroundMusic/Fade)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* BackgroundMusic_FadeAudio_mD7398B28240D708B158C36E048E4841A73E62C85 (BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* __this, float ___time0, int32_t ___fadeType1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* L_0 = (U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB*)il2cpp_codegen_object_new(U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CFadeAudioU3Ed__6__ctor_m687944A3905C69B94A4993E8D36271A36842346F(L_0, 0, NULL);
		U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_4 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_4), (void*)__this);
		U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* L_2 = L_1;
		float L_3 = ___time0;
		NullCheck(L_2);
		L_2->___time_3 = L_3;
		U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* L_4 = L_2;
		int32_t L_5 = ___fadeType1;
		NullCheck(L_4);
		L_4->___fadeType_2 = L_5;
		return L_4;
	}
}
// System.Void Ricimi.BackgroundMusic::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BackgroundMusic__ctor_mB18F66DDF20371A5B2343EE5413A9302AB1E92EE (BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.BackgroundMusic/<FadeAudio>d__6::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CFadeAudioU3Ed__6__ctor_m687944A3905C69B94A4993E8D36271A36842346F (U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->___U3CU3E1__state_0 = L_0;
		return;
	}
}
// System.Void Ricimi.BackgroundMusic/<FadeAudio>d__6::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CFadeAudioU3Ed__6_System_IDisposable_Dispose_mB010B6652CEFD5A48534198776D8E5A6EA4B7254 (U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean Ricimi.BackgroundMusic/<FadeAudio>d__6::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CFadeAudioU3Ed__6_MoveNext_m5439669AA6E380E9F812C9FF46B20D436E5DC436 (U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* V_1 = NULL;
	U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* G_B5_0 = NULL;
	U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* G_B4_0 = NULL;
	float G_B6_0 = 0.0f;
	U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* G_B6_1 = NULL;
	U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* G_B8_0 = NULL;
	U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* G_B7_0 = NULL;
	float G_B9_0 = 0.0f;
	U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* G_B9_1 = NULL;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* L_1 = __this->___U3CU3E4__this_4;
		V_1 = L_1;
		int32_t L_2 = V_0;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)1)))
		{
			goto IL_00cf;
		}
	}
	{
		return (bool)0;
	}

IL_001a:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// var start = fadeType == Fade.In ? 0.0f : 1.0f;
		int32_t L_4 = __this->___fadeType_2;
		G_B4_0 = __this;
		if (!L_4)
		{
			G_B5_0 = __this;
			goto IL_0031;
		}
	}
	{
		G_B6_0 = (1.0f);
		G_B6_1 = G_B4_0;
		goto IL_0036;
	}

IL_0031:
	{
		G_B6_0 = (0.0f);
		G_B6_1 = G_B5_0;
	}

IL_0036:
	{
		NullCheck(G_B6_1);
		G_B6_1->___U3CstartU3E5__2_5 = G_B6_0;
		// var end = fadeType == Fade.In ? 1.0f : 0.0f;
		int32_t L_5 = __this->___fadeType_2;
		G_B7_0 = __this;
		if (!L_5)
		{
			G_B8_0 = __this;
			goto IL_004b;
		}
	}
	{
		G_B9_0 = (0.0f);
		G_B9_1 = G_B7_0;
		goto IL_0050;
	}

IL_004b:
	{
		G_B9_0 = (1.0f);
		G_B9_1 = G_B8_0;
	}

IL_0050:
	{
		NullCheck(G_B9_1);
		G_B9_1->___U3CendU3E5__3_6 = G_B9_0;
		// var i = 0.0f;
		__this->___U3CiU3E5__4_7 = (0.0f);
		// var step = 1.0f / time;
		float L_6 = __this->___time_3;
		__this->___U3CstepU3E5__5_8 = ((float)((1.0f)/L_6));
		goto IL_00d6;
	}

IL_0074:
	{
		// i += step * Time.deltaTime;
		float L_7 = __this->___U3CiU3E5__4_7;
		float L_8 = __this->___U3CstepU3E5__5_8;
		float L_9;
		L_9 = Time_get_deltaTime_mC3195000401F0FD167DD2F948FD2BC58330D0865(NULL);
		__this->___U3CiU3E5__4_7 = ((float)il2cpp_codegen_add(L_7, ((float)il2cpp_codegen_multiply(L_8, L_9))));
		// m_audioSource.volume = Mathf.Lerp(start, end, i);
		BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* L_10 = V_1;
		NullCheck(L_10);
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_11 = L_10->___m_audioSource_5;
		float L_12 = __this->___U3CstartU3E5__2_5;
		float L_13 = __this->___U3CendU3E5__3_6;
		float L_14 = __this->___U3CiU3E5__4_7;
		float L_15;
		L_15 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(L_12, L_13, L_14, NULL);
		NullCheck(L_11);
		AudioSource_set_volume_mD902BBDBBDE0E3C148609BF3C05096148E90F2C0(L_11, L_15, NULL);
		// yield return new WaitForSeconds(step * Time.deltaTime);
		float L_16 = __this->___U3CstepU3E5__5_8;
		float L_17;
		L_17 = Time_get_deltaTime_mC3195000401F0FD167DD2F948FD2BC58330D0865(NULL);
		WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3* L_18 = (WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3*)il2cpp_codegen_object_new(WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var);
		NullCheck(L_18);
		WaitForSeconds__ctor_m579F95BADEDBAB4B3A7E302C6EE3995926EF2EFC(L_18, ((float)il2cpp_codegen_multiply(L_16, L_17)), NULL);
		__this->___U3CU3E2__current_1 = L_18;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_18);
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_00cf:
	{
		__this->___U3CU3E1__state_0 = (-1);
	}

IL_00d6:
	{
		// while (i <= 1.0f)
		float L_19 = __this->___U3CiU3E5__4_7;
		if ((((float)L_19) <= ((float)(1.0f))))
		{
			goto IL_0074;
		}
	}
	{
		// }
		return (bool)0;
	}
}
// System.Object Ricimi.BackgroundMusic/<FadeAudio>d__6::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CFadeAudioU3Ed__6_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_m55CDC71005AB75E367CC652E8EC5C0EF47934317 (U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void Ricimi.BackgroundMusic/<FadeAudio>d__6::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CFadeAudioU3Ed__6_System_Collections_IEnumerator_Reset_mC26FF5D3A3046339A396FF326BBB4556ED102C34 (U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CFadeAudioU3Ed__6_System_Collections_IEnumerator_Reset_mC26FF5D3A3046339A396FF326BBB4556ED102C34_RuntimeMethod_var)));
	}
}
// System.Object Ricimi.BackgroundMusic/<FadeAudio>d__6::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CFadeAudioU3Ed__6_System_Collections_IEnumerator_get_Current_m4DD06718DB4CC4BFA7B8C1F5EE541A94C21DF1B7 (U3CFadeAudioU3Ed__6_tF64DF24917CC8B885F4C6977FB5231B5B033FECB* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.ColorSwapper::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ColorSwapper_Awake_m312B2ED92408655723B9CCCD0DBFC324A1FFEB8A (ColorSwapper_t5F1C217CDAE4B913B63FBEADD2AC2D6D27F4171A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mE74EE63C85A63FC34DCFC631BC229207B420BC79_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_image = GetComponent<Image>();
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_0;
		L_0 = Component_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mE74EE63C85A63FC34DCFC631BC229207B420BC79(__this, Component_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mE74EE63C85A63FC34DCFC631BC229207B420BC79_RuntimeMethod_var);
		__this->___m_image_7 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_image_7), (void*)L_0);
		// }
		return;
	}
}
// System.Void Ricimi.ColorSwapper::SwapColor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ColorSwapper_SwapColor_m983FBDA1654EBA0DCA1E04ACBD19FDFC2A8EA266 (ColorSwapper_t5F1C217CDAE4B913B63FBEADD2AC2D6D27F4171A* __this, const RuntimeMethod* method) 
{
	{
		// if (m_swapped)
		bool L_0 = __this->___m_swapped_6;
		if (!L_0)
		{
			goto IL_0021;
		}
	}
	{
		// m_swapped = false;
		__this->___m_swapped_6 = (bool)0;
		// m_image.color = disabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_1 = __this->___m_image_7;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = __this->___disabledColor_5;
		NullCheck(L_1);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_1, L_2);
		return;
	}

IL_0021:
	{
		// m_swapped = true;
		__this->___m_swapped_6 = (bool)1;
		// m_image.color = enabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = __this->___m_image_7;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = __this->___enabledColor_4;
		NullCheck(L_3);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_3, L_4);
		// }
		return;
	}
}
// System.Void Ricimi.ColorSwapper::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ColorSwapper__ctor_m5345A8474A83F9722373EB528C384A3F57E67EEB (ColorSwapper_t5F1C217CDAE4B913B63FBEADD2AC2D6D27F4171A* __this, const RuntimeMethod* method) 
{
	{
		// private bool m_swapped = true;
		__this->___m_swapped_6 = (bool)1;
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.Fader::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Fader_Awake_mFA11788E435DAAA9321E04F09DBE38418DD7F29D (Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisCanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094_mA3B0428368982ED39ADEBB220EE67D1E99D8B2D2_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_canvasGroup = GetComponent<CanvasGroup>();
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_0;
		L_0 = Component_GetComponent_TisCanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094_mA3B0428368982ED39ADEBB220EE67D1E99D8B2D2(__this, Component_GetComponent_TisCanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094_mA3B0428368982ED39ADEBB220EE67D1E99D8B2D2_RuntimeMethod_var);
		__this->___m_canvasGroup_5 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_canvasGroup_5), (void*)L_0);
		// }
		return;
	}
}
// System.Void Ricimi.Fader::FadeIn()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Fader_FadeIn_m93D415E9589DEFD0F8E47026CB71CF8E9C0BA24D (Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* __this, const RuntimeMethod* method) 
{
	{
		// StartCoroutine(RunFadeIn());
		RuntimeObject* L_0;
		L_0 = Fader_RunFadeIn_mB12ED0B7591B11E3BD1C479DAAE2BDB883F7AEC6(__this, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_1;
		L_1 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_0, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.Fader::FadeOut()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Fader_FadeOut_mED24274D8C73785D6F8766566818081BD9DD4012 (Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* __this, const RuntimeMethod* method) 
{
	{
		// StartCoroutine(RunFadeOut());
		RuntimeObject* L_0;
		L_0 = Fader_RunFadeOut_mFFA3099CB41258FE67A256EF90F6F914DBB1F4E4(__this, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_1;
		L_1 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_0, NULL);
		// }
		return;
	}
}
// System.Collections.IEnumerator Ricimi.Fader::RunFadeIn()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Fader_RunFadeIn_mB12ED0B7591B11E3BD1C479DAAE2BDB883F7AEC6 (Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* L_0 = (U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A*)il2cpp_codegen_object_new(U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CRunFadeInU3Ed__5__ctor_mE355828D91A7F1F4D98929FFF387D5416D5F07C1(L_0, 0, NULL);
		U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_2 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_2), (void*)__this);
		return L_1;
	}
}
// System.Collections.IEnumerator Ricimi.Fader::RunFadeOut()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Fader_RunFadeOut_mFFA3099CB41258FE67A256EF90F6F914DBB1F4E4 (Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* L_0 = (U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039*)il2cpp_codegen_object_new(U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CRunFadeOutU3Ed__6__ctor_m9F0F922BFEF5952EFDAED815119E4E7FF5F8C018(L_0, 0, NULL);
		U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_2 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_2), (void*)__this);
		return L_1;
	}
}
// System.Void Ricimi.Fader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Fader__ctor_m658C9FCC314C548F0476775DD695E4BE7AF35A5E (Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* __this, const RuntimeMethod* method) 
{
	{
		// public float duration = 0.5f;
		__this->___duration_4 = (0.5f);
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.Fader/<RunFadeIn>d__5::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeInU3Ed__5__ctor_mE355828D91A7F1F4D98929FFF387D5416D5F07C1 (U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->___U3CU3E1__state_0 = L_0;
		return;
	}
}
// System.Void Ricimi.Fader/<RunFadeIn>d__5::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeInU3Ed__5_System_IDisposable_Dispose_mADD202AA0544A27F0AB01502ABB90B2EA2BBE6DC (U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean Ricimi.Fader/<RunFadeIn>d__5::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CRunFadeInU3Ed__5_MoveNext_m4B6D46D3DF5689C18A4591F84B19A2B4DE70E7C2 (U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* V_1 = NULL;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_1 = __this->___U3CU3E4__this_2;
		V_1 = L_1;
		int32_t L_2 = V_0;
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)1)))
		{
			goto IL_008a;
		}
	}
	{
		return (bool)0;
	}

IL_0017:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// var time = 0.0f;
		__this->___U3CtimeU3E5__2_3 = (0.0f);
		// var initialAlpha = m_canvasGroup.alpha;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_4 = V_1;
		NullCheck(L_4);
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_5 = L_4->___m_canvasGroup_5;
		NullCheck(L_5);
		float L_6;
		L_6 = CanvasGroup_get_alpha_mBFEA193D2886B27CC53B31F90F7A1659B67ED6DF(L_5, NULL);
		__this->___U3CinitialAlphaU3E5__3_4 = L_6;
		goto IL_0091;
	}

IL_003c:
	{
		// time += Time.deltaTime;
		float L_7 = __this->___U3CtimeU3E5__2_3;
		float L_8;
		L_8 = Time_get_deltaTime_mC3195000401F0FD167DD2F948FD2BC58330D0865(NULL);
		__this->___U3CtimeU3E5__2_3 = ((float)il2cpp_codegen_add(L_7, L_8));
		// m_canvasGroup.alpha = Mathf.Lerp(initialAlpha, 1.0f, time / duration);
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_9 = V_1;
		NullCheck(L_9);
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_10 = L_9->___m_canvasGroup_5;
		float L_11 = __this->___U3CinitialAlphaU3E5__3_4;
		float L_12 = __this->___U3CtimeU3E5__2_3;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_13 = V_1;
		NullCheck(L_13);
		float L_14 = L_13->___duration_4;
		float L_15;
		L_15 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(L_11, (1.0f), ((float)(L_12/L_14)), NULL);
		NullCheck(L_10);
		CanvasGroup_set_alpha_m5C06839316D948BB4F75ED72C87FA1F1A20C333F(L_10, L_15, NULL);
		// yield return new WaitForEndOfFrame();
		WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663* L_16 = (WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663*)il2cpp_codegen_object_new(WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		NullCheck(L_16);
		WaitForEndOfFrame__ctor_m4AF7E576C01E6B04443BB898B1AE5D645F7D45AB(L_16, NULL);
		__this->___U3CU3E2__current_1 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_16);
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_008a:
	{
		__this->___U3CU3E1__state_0 = (-1);
	}

IL_0091:
	{
		// while (time < duration)
		float L_17 = __this->___U3CtimeU3E5__2_3;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_18 = V_1;
		NullCheck(L_18);
		float L_19 = L_18->___duration_4;
		if ((((float)L_17) < ((float)L_19)))
		{
			goto IL_003c;
		}
	}
	{
		// m_canvasGroup.interactable = true;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_20 = V_1;
		NullCheck(L_20);
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_21 = L_20->___m_canvasGroup_5;
		NullCheck(L_21);
		CanvasGroup_set_interactable_m86928BB0894EF3F06BC7BE63594272FBA0DAC757(L_21, (bool)1, NULL);
		// m_canvasGroup.blocksRaycasts = true;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_22 = V_1;
		NullCheck(L_22);
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_23 = L_22->___m_canvasGroup_5;
		NullCheck(L_23);
		CanvasGroup_set_blocksRaycasts_m6C17F35782D16AE3FC42FCD1A4D68E1C4A4776E0(L_23, (bool)1, NULL);
		// }
		return (bool)0;
	}
}
// System.Object Ricimi.Fader/<RunFadeIn>d__5::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CRunFadeInU3Ed__5_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mFE0B9C7C9A8E6894AA95EA83924D05EE338BE65F (U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void Ricimi.Fader/<RunFadeIn>d__5::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeInU3Ed__5_System_Collections_IEnumerator_Reset_m752BB6020A57F176139BC360D65032BCEA6324B6 (U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CRunFadeInU3Ed__5_System_Collections_IEnumerator_Reset_m752BB6020A57F176139BC360D65032BCEA6324B6_RuntimeMethod_var)));
	}
}
// System.Object Ricimi.Fader/<RunFadeIn>d__5::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CRunFadeInU3Ed__5_System_Collections_IEnumerator_get_Current_m9838B90C4B50862897F619CDEE26D847D8E93797 (U3CRunFadeInU3Ed__5_t090DB2DDCA96987B21E3DF87BFBF88030ABB890A* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.Fader/<RunFadeOut>d__6::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeOutU3Ed__6__ctor_m9F0F922BFEF5952EFDAED815119E4E7FF5F8C018 (U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->___U3CU3E1__state_0 = L_0;
		return;
	}
}
// System.Void Ricimi.Fader/<RunFadeOut>d__6::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeOutU3Ed__6_System_IDisposable_Dispose_mF846B13864169CA60CAFF5195281C8EAAEABC1EC (U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean Ricimi.Fader/<RunFadeOut>d__6::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CRunFadeOutU3Ed__6_MoveNext_m94C8EF69D2CC99CF97C757F4AE8D8568106E455E (U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* V_1 = NULL;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_1 = __this->___U3CU3E4__this_2;
		V_1 = L_1;
		int32_t L_2 = V_0;
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)1)))
		{
			goto IL_008a;
		}
	}
	{
		return (bool)0;
	}

IL_0017:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// var time = 0.0f;
		__this->___U3CtimeU3E5__2_3 = (0.0f);
		// var initialAlpha = m_canvasGroup.alpha;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_4 = V_1;
		NullCheck(L_4);
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_5 = L_4->___m_canvasGroup_5;
		NullCheck(L_5);
		float L_6;
		L_6 = CanvasGroup_get_alpha_mBFEA193D2886B27CC53B31F90F7A1659B67ED6DF(L_5, NULL);
		__this->___U3CinitialAlphaU3E5__3_4 = L_6;
		goto IL_0091;
	}

IL_003c:
	{
		// time += Time.deltaTime;
		float L_7 = __this->___U3CtimeU3E5__2_3;
		float L_8;
		L_8 = Time_get_deltaTime_mC3195000401F0FD167DD2F948FD2BC58330D0865(NULL);
		__this->___U3CtimeU3E5__2_3 = ((float)il2cpp_codegen_add(L_7, L_8));
		// m_canvasGroup.alpha = Mathf.Lerp(initialAlpha, 0.0f, time / duration);
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_9 = V_1;
		NullCheck(L_9);
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_10 = L_9->___m_canvasGroup_5;
		float L_11 = __this->___U3CinitialAlphaU3E5__3_4;
		float L_12 = __this->___U3CtimeU3E5__2_3;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_13 = V_1;
		NullCheck(L_13);
		float L_14 = L_13->___duration_4;
		float L_15;
		L_15 = Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline(L_11, (0.0f), ((float)(L_12/L_14)), NULL);
		NullCheck(L_10);
		CanvasGroup_set_alpha_m5C06839316D948BB4F75ED72C87FA1F1A20C333F(L_10, L_15, NULL);
		// yield return new WaitForEndOfFrame();
		WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663* L_16 = (WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663*)il2cpp_codegen_object_new(WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		NullCheck(L_16);
		WaitForEndOfFrame__ctor_m4AF7E576C01E6B04443BB898B1AE5D645F7D45AB(L_16, NULL);
		__this->___U3CU3E2__current_1 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_16);
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_008a:
	{
		__this->___U3CU3E1__state_0 = (-1);
	}

IL_0091:
	{
		// while (time < duration)
		float L_17 = __this->___U3CtimeU3E5__2_3;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_18 = V_1;
		NullCheck(L_18);
		float L_19 = L_18->___duration_4;
		if ((((float)L_17) < ((float)L_19)))
		{
			goto IL_003c;
		}
	}
	{
		// m_canvasGroup.interactable = false;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_20 = V_1;
		NullCheck(L_20);
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_21 = L_20->___m_canvasGroup_5;
		NullCheck(L_21);
		CanvasGroup_set_interactable_m86928BB0894EF3F06BC7BE63594272FBA0DAC757(L_21, (bool)0, NULL);
		// m_canvasGroup.blocksRaycasts = false;
		Fader_tAF5C17ECC2E2D0BCA49511FC0B9AB4FBD5E93DFF* L_22 = V_1;
		NullCheck(L_22);
		CanvasGroup_t048C1461B14628CFAEBE6E7353093ADB04EBC094* L_23 = L_22->___m_canvasGroup_5;
		NullCheck(L_23);
		CanvasGroup_set_blocksRaycasts_m6C17F35782D16AE3FC42FCD1A4D68E1C4A4776E0(L_23, (bool)0, NULL);
		// }
		return (bool)0;
	}
}
// System.Object Ricimi.Fader/<RunFadeOut>d__6::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CRunFadeOutU3Ed__6_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mB138566FCBB16D20DBD4E1EFC04837EA73E94C09 (U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void Ricimi.Fader/<RunFadeOut>d__6::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeOutU3Ed__6_System_Collections_IEnumerator_Reset_mCF19D9B85EFF5445A99D58C5113A316B09A3971B (U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CRunFadeOutU3Ed__6_System_Collections_IEnumerator_Reset_mCF19D9B85EFF5445A99D58C5113A316B09A3971B_RuntimeMethod_var)));
	}
}
// System.Object Ricimi.Fader/<RunFadeOut>d__6::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CRunFadeOutU3Ed__6_System_Collections_IEnumerator_get_Current_mAC6CBAE93A2D7DF88A83C02390550EE523F0F85C (U3CRunFadeOutU3Ed__6_t526609B813ECD09AB7173ACDA7716FE4F89A3039* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.InitialPlayerPrefs::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InitialPlayerPrefs_Awake_mC9E761CF858D7D799A8C446C3627C9614D4043B7 (InitialPlayerPrefs_tFB58CC4998B1CC4D458FD13F089ED23F01C784EA* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (!PlayerPrefs.HasKey("music_on"))
		bool L_0;
		L_0 = PlayerPrefs_HasKey_mCA5C64BBA6BF8B230BC3BC92B4761DD3B11D4668(_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E, NULL);
		if (L_0)
		{
			goto IL_0017;
		}
	}
	{
		// PlayerPrefs.SetInt("music_on", 1);
		PlayerPrefs_SetInt_m956D3E2DB966F20CF42F842880DDF9E2BE94D948(_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E, 1, NULL);
	}

IL_0017:
	{
		// if (!PlayerPrefs.HasKey("sound_on"))
		bool L_1;
		L_1 = PlayerPrefs_HasKey_mCA5C64BBA6BF8B230BC3BC92B4761DD3B11D4668(_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD, NULL);
		if (L_1)
		{
			goto IL_002e;
		}
	}
	{
		// PlayerPrefs.SetInt("sound_on", 1);
		PlayerPrefs_SetInt_m956D3E2DB966F20CF42F842880DDF9E2BE94D948(_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD, 1, NULL);
	}

IL_002e:
	{
		// }
		return;
	}
}
// System.Void Ricimi.InitialPlayerPrefs::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InitialPlayerPrefs__ctor_m33FC737BA7F1FAA2F17545BD681F6018955C76C2 (InitialPlayerPrefs_tFB58CC4998B1CC4D458FD13F089ED23F01C784EA* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.LevelScene::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_Awake_m541C929BAB2B9769CA93D63DC8C04D0F092A4625 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_mB84A0931B2081CCADE7C5D459B2A8FAA6D3D3BD3_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_animator = levelGroup.GetComponent<Animator>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___levelGroup_6;
		NullCheck(L_0);
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_1;
		L_1 = GameObject_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_mB84A0931B2081CCADE7C5D459B2A8FAA6D3D3BD3(L_0, GameObject_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_mB84A0931B2081CCADE7C5D459B2A8FAA6D3D3BD3_RuntimeMethod_var);
		__this->___m_animator_10 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_animator_10), (void*)L_1);
		// }
		return;
	}
}
// System.Void Ricimi.LevelScene::ShowPreviousLevels()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_ShowPreviousLevels_mDCB81EBDB789F3EA2AD03A793B081D4E67B21CE2 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral78ED5F064518257EE2A43CDF95BFC6D9694BEC47);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE52EB343FFBB01D406760FC6F6DABBD77D302C08);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// --m_currentLevelIndex;
		int32_t L_0 = __this->___m_currentLevelIndex_9;
		__this->___m_currentLevelIndex_9 = ((int32_t)il2cpp_codegen_subtract(L_0, 1));
		// if (m_currentLevelIndex < 0)
		int32_t L_1 = __this->___m_currentLevelIndex_9;
		if ((((int32_t)L_1) >= ((int32_t)0)))
		{
			goto IL_001e;
		}
	}
	{
		// m_currentLevelIndex = 0;
		__this->___m_currentLevelIndex_9 = 0;
	}

IL_001e:
	{
		// SetLevelText(m_currentLevelIndex + 1);
		int32_t L_2 = __this->___m_currentLevelIndex_9;
		LevelScene_SetLevelText_m5FFCF3901318FBB567217F1B986039653DE4B693(__this, ((int32_t)il2cpp_codegen_add(L_2, 1)), NULL);
		// switch (m_currentLevelIndex)
		int32_t L_3 = __this->___m_currentLevelIndex_9;
		V_0 = L_3;
		int32_t L_4 = V_0;
		if (!L_4)
		{
			goto IL_003b;
		}
	}
	{
		int32_t L_5 = V_0;
		if ((((int32_t)L_5) == ((int32_t)1)))
		{
			goto IL_006d;
		}
	}
	{
		return;
	}

IL_003b:
	{
		// if (!m_animator.GetCurrentAnimatorStateInfo(0).IsName("Animation4"))
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_6 = __this->___m_animator_10;
		NullCheck(L_6);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_7;
		L_7 = Animator_GetCurrentAnimatorStateInfo_mD5B526FA605F6CFBC31B7DE36740F6AD1E534CAD(L_6, 0, NULL);
		V_1 = L_7;
		bool L_8;
		L_8 = AnimatorStateInfo_IsName_mB936F493D6BDDB9372C8E9D813CE0416B002C4D0((&V_1), _stringLiteralE52EB343FFBB01D406760FC6F6DABBD77D302C08, NULL);
		if (L_8)
		{
			goto IL_0066;
		}
	}
	{
		// m_animator.Play("Animation4");
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_9 = __this->___m_animator_10;
		NullCheck(L_9);
		Animator_Play_m0F6A9F84B2E256E644D56C34A7A9BD622CB00FF9(L_9, _stringLiteralE52EB343FFBB01D406760FC6F6DABBD77D302C08, NULL);
	}

IL_0066:
	{
		// DisablePrevLevelButton();
		LevelScene_DisablePrevLevelButton_mE3856D7E5E195B74D6D572199454534C4CECC897(__this, NULL);
		// break;
		return;
	}

IL_006d:
	{
		// if (!m_animator.GetCurrentAnimatorStateInfo(0).IsName("Animation3"))
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_10 = __this->___m_animator_10;
		NullCheck(L_10);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_11;
		L_11 = Animator_GetCurrentAnimatorStateInfo_mD5B526FA605F6CFBC31B7DE36740F6AD1E534CAD(L_10, 0, NULL);
		V_1 = L_11;
		bool L_12;
		L_12 = AnimatorStateInfo_IsName_mB936F493D6BDDB9372C8E9D813CE0416B002C4D0((&V_1), _stringLiteral78ED5F064518257EE2A43CDF95BFC6D9694BEC47, NULL);
		if (L_12)
		{
			goto IL_0098;
		}
	}
	{
		// m_animator.Play("Animation3");
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_13 = __this->___m_animator_10;
		NullCheck(L_13);
		Animator_Play_m0F6A9F84B2E256E644D56C34A7A9BD622CB00FF9(L_13, _stringLiteral78ED5F064518257EE2A43CDF95BFC6D9694BEC47, NULL);
	}

IL_0098:
	{
		// EnablePrevLevelButton();
		LevelScene_EnablePrevLevelButton_m3840739BCC8B4D2247839817C268A407DD12117E(__this, NULL);
		// EnableNextLevelButton();
		LevelScene_EnableNextLevelButton_m26149E54E47768E75DA515DA7ACAD42BBF5F2024(__this, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.LevelScene::ShowNextLevels()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_ShowNextLevels_m38089DE9DB0FC8C1946D3B68FC016D441F5D0DA6 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5D48754EEDD124010E593542F383BB714807301A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8DFA5A8CC04AC53F0ACE396F9570B4A33CD4F7FA);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// ++m_currentLevelIndex;
		int32_t L_0 = __this->___m_currentLevelIndex_9;
		__this->___m_currentLevelIndex_9 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		// if (m_currentLevelIndex == numLevelIndexes)
		int32_t L_1 = __this->___m_currentLevelIndex_9;
		if ((!(((uint32_t)L_1) == ((uint32_t)3))))
		{
			goto IL_001e;
		}
	}
	{
		// m_currentLevelIndex = numLevelIndexes - 1;
		__this->___m_currentLevelIndex_9 = 2;
	}

IL_001e:
	{
		// SetLevelText(m_currentLevelIndex + 1);
		int32_t L_2 = __this->___m_currentLevelIndex_9;
		LevelScene_SetLevelText_m5FFCF3901318FBB567217F1B986039653DE4B693(__this, ((int32_t)il2cpp_codegen_add(L_2, 1)), NULL);
		// switch (m_currentLevelIndex)
		int32_t L_3 = __this->___m_currentLevelIndex_9;
		V_0 = L_3;
		int32_t L_4 = V_0;
		if ((((int32_t)L_4) == ((int32_t)1)))
		{
			goto IL_003c;
		}
	}
	{
		int32_t L_5 = V_0;
		if ((((int32_t)L_5) == ((int32_t)2)))
		{
			goto IL_0074;
		}
	}
	{
		return;
	}

IL_003c:
	{
		// if (!m_animator.GetCurrentAnimatorStateInfo(0).IsName("Animation1"))
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_6 = __this->___m_animator_10;
		NullCheck(L_6);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_7;
		L_7 = Animator_GetCurrentAnimatorStateInfo_mD5B526FA605F6CFBC31B7DE36740F6AD1E534CAD(L_6, 0, NULL);
		V_1 = L_7;
		bool L_8;
		L_8 = AnimatorStateInfo_IsName_mB936F493D6BDDB9372C8E9D813CE0416B002C4D0((&V_1), _stringLiteral5D48754EEDD124010E593542F383BB714807301A, NULL);
		if (L_8)
		{
			goto IL_0067;
		}
	}
	{
		// m_animator.Play("Animation1");
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_9 = __this->___m_animator_10;
		NullCheck(L_9);
		Animator_Play_m0F6A9F84B2E256E644D56C34A7A9BD622CB00FF9(L_9, _stringLiteral5D48754EEDD124010E593542F383BB714807301A, NULL);
	}

IL_0067:
	{
		// EnablePrevLevelButton();
		LevelScene_EnablePrevLevelButton_m3840739BCC8B4D2247839817C268A407DD12117E(__this, NULL);
		// EnableNextLevelButton();
		LevelScene_EnableNextLevelButton_m26149E54E47768E75DA515DA7ACAD42BBF5F2024(__this, NULL);
		// break;
		return;
	}

IL_0074:
	{
		// if (!m_animator.GetCurrentAnimatorStateInfo(0).IsName("Animation2"))
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_10 = __this->___m_animator_10;
		NullCheck(L_10);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_11;
		L_11 = Animator_GetCurrentAnimatorStateInfo_mD5B526FA605F6CFBC31B7DE36740F6AD1E534CAD(L_10, 0, NULL);
		V_1 = L_11;
		bool L_12;
		L_12 = AnimatorStateInfo_IsName_mB936F493D6BDDB9372C8E9D813CE0416B002C4D0((&V_1), _stringLiteral8DFA5A8CC04AC53F0ACE396F9570B4A33CD4F7FA, NULL);
		if (L_12)
		{
			goto IL_009f;
		}
	}
	{
		// m_animator.Play("Animation2");
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_13 = __this->___m_animator_10;
		NullCheck(L_13);
		Animator_Play_m0F6A9F84B2E256E644D56C34A7A9BD622CB00FF9(L_13, _stringLiteral8DFA5A8CC04AC53F0ACE396F9570B4A33CD4F7FA, NULL);
	}

IL_009f:
	{
		// DisableNextLevelButton();
		LevelScene_DisableNextLevelButton_m2D977B427742B6D16D02C651A59FC26FA34FFDC2(__this, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.LevelScene::EnablePrevLevelButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_EnablePrevLevelButton_m3840739BCC8B4D2247839817C268A407DD12117E (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var image = prevLevelButton.GetComponentsInChildren<Image>()[1];
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___prevLevelButton_4;
		NullCheck(L_0);
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_1;
		L_1 = GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA(L_0, GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		NullCheck(L_1);
		int32_t L_2 = 1;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		// var newColor = image.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_4 = L_3;
		NullCheck(L_4);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_5;
		L_5 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_4);
		V_0 = L_5;
		// newColor.a = 1.0f;
		(&V_0)->___a_3 = (1.0f);
		// image.color = newColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = V_0;
		NullCheck(L_4);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_4, L_6);
		// var shadow = prevLevelButton.GetComponentsInChildren<Image>()[0];
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_7 = __this->___prevLevelButton_4;
		NullCheck(L_7);
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_8;
		L_8 = GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA(L_7, GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		NullCheck(L_8);
		int32_t L_9 = 0;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		// var newShadowColor = shadow.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_11 = L_10;
		NullCheck(L_11);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_12;
		L_12 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_11);
		V_1 = L_12;
		// newShadowColor.a = 1.0f;
		(&V_1)->___a_3 = (1.0f);
		// shadow.color = newShadowColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_13 = V_1;
		NullCheck(L_11);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_11, L_13);
		// prevLevelButton.GetComponent<AnimatedButton>().interactable = true;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_14 = __this->___prevLevelButton_4;
		NullCheck(L_14);
		AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* L_15;
		L_15 = GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038(L_14, GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var);
		NullCheck(L_15);
		L_15->___interactable_4 = (bool)1;
		// }
		return;
	}
}
// System.Void Ricimi.LevelScene::DisablePrevLevelButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_DisablePrevLevelButton_mE3856D7E5E195B74D6D572199454534C4CECC897 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var image = prevLevelButton.GetComponentsInChildren<Image>()[1];
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___prevLevelButton_4;
		NullCheck(L_0);
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_1;
		L_1 = GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA(L_0, GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		NullCheck(L_1);
		int32_t L_2 = 1;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		// var newColor = image.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_4 = L_3;
		NullCheck(L_4);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_5;
		L_5 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_4);
		V_0 = L_5;
		// newColor.a = 40 / 255.0f;
		(&V_0)->___a_3 = (0.156862751f);
		// image.color = newColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = V_0;
		NullCheck(L_4);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_4, L_6);
		// var shadow = prevLevelButton.GetComponentsInChildren<Image>()[0];
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_7 = __this->___prevLevelButton_4;
		NullCheck(L_7);
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_8;
		L_8 = GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA(L_7, GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		NullCheck(L_8);
		int32_t L_9 = 0;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		// var newShadowColor = shadow.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_11 = L_10;
		NullCheck(L_11);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_12;
		L_12 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_11);
		V_1 = L_12;
		// newShadowColor.a = 0.0f;
		(&V_1)->___a_3 = (0.0f);
		// shadow.color = newShadowColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_13 = V_1;
		NullCheck(L_11);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_11, L_13);
		// prevLevelButton.GetComponent<AnimatedButton>().interactable = false;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_14 = __this->___prevLevelButton_4;
		NullCheck(L_14);
		AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* L_15;
		L_15 = GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038(L_14, GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var);
		NullCheck(L_15);
		L_15->___interactable_4 = (bool)0;
		// }
		return;
	}
}
// System.Void Ricimi.LevelScene::EnableNextLevelButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_EnableNextLevelButton_m26149E54E47768E75DA515DA7ACAD42BBF5F2024 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var image = nextLevelButton.GetComponentsInChildren<Image>()[1];
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___nextLevelButton_5;
		NullCheck(L_0);
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_1;
		L_1 = GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA(L_0, GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		NullCheck(L_1);
		int32_t L_2 = 1;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		// var newColor = image.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_4 = L_3;
		NullCheck(L_4);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_5;
		L_5 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_4);
		V_0 = L_5;
		// newColor.a = 1.0f;
		(&V_0)->___a_3 = (1.0f);
		// image.color = newColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = V_0;
		NullCheck(L_4);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_4, L_6);
		// var shadow = nextLevelButton.GetComponentsInChildren<Image>()[0];
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_7 = __this->___nextLevelButton_5;
		NullCheck(L_7);
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_8;
		L_8 = GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA(L_7, GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		NullCheck(L_8);
		int32_t L_9 = 0;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		// var newShadowColor = shadow.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_11 = L_10;
		NullCheck(L_11);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_12;
		L_12 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_11);
		V_1 = L_12;
		// newShadowColor.a = 1.0f;
		(&V_1)->___a_3 = (1.0f);
		// shadow.color = newShadowColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_13 = V_1;
		NullCheck(L_11);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_11, L_13);
		// nextLevelButton.GetComponent<AnimatedButton>().interactable = true;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_14 = __this->___nextLevelButton_5;
		NullCheck(L_14);
		AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* L_15;
		L_15 = GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038(L_14, GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var);
		NullCheck(L_15);
		L_15->___interactable_4 = (bool)1;
		// }
		return;
	}
}
// System.Void Ricimi.LevelScene::DisableNextLevelButton()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_DisableNextLevelButton_m2D977B427742B6D16D02C651A59FC26FA34FFDC2 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var image = nextLevelButton.GetComponentsInChildren<Image>()[1];
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___nextLevelButton_5;
		NullCheck(L_0);
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_1;
		L_1 = GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA(L_0, GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		NullCheck(L_1);
		int32_t L_2 = 1;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		// var newColor = image.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_4 = L_3;
		NullCheck(L_4);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_5;
		L_5 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_4);
		V_0 = L_5;
		// newColor.a = 40 / 255.0f;
		(&V_0)->___a_3 = (0.156862751f);
		// image.color = newColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = V_0;
		NullCheck(L_4);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_4, L_6);
		// var shadow = nextLevelButton.GetComponentsInChildren<Image>()[0];
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_7 = __this->___nextLevelButton_5;
		NullCheck(L_7);
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_8;
		L_8 = GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA(L_7, GameObject_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mC8B5ACBEEF3B80C0B0FB6B10286C4524EB9FADEA_RuntimeMethod_var);
		NullCheck(L_8);
		int32_t L_9 = 0;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		// var newShadowColor = shadow.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_11 = L_10;
		NullCheck(L_11);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_12;
		L_12 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_11);
		V_1 = L_12;
		// newShadowColor.a = 0.0f;
		(&V_1)->___a_3 = (0.0f);
		// shadow.color = newShadowColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_13 = V_1;
		NullCheck(L_11);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_11, L_13);
		// nextLevelButton.GetComponent<AnimatedButton>().interactable = false;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_14 = __this->___nextLevelButton_5;
		NullCheck(L_14);
		AnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E* L_15;
		L_15 = GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038(L_14, GameObject_GetComponent_TisAnimatedButton_t3F72111252EC9D94EE96CE7D1D814E4A89A78E9E_mE8306E6CA2A354F00C13CB1CBB5AE2472D606038_RuntimeMethod_var);
		NullCheck(L_15);
		L_15->___interactable_4 = (bool)0;
		// }
		return;
	}
}
// System.Void Ricimi.LevelScene::SetLevelText(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene_SetLevelText_m5FFCF3901318FBB567217F1B986039653DE4B693 (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, int32_t ___level0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral63D0716BC6E71CF8171A831003482E728DFDD739);
		s_Il2CppMethodInitialized = true;
	}
	{
		// levelText.text = level.ToString() + "/3";
		Text_tD60B2346DAA6666BF0D822FF607F0B220C2B9E62* L_0 = __this->___levelText_7;
		String_t* L_1;
		L_1 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5((&___level0), NULL);
		String_t* L_2;
		L_2 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_1, _stringLiteral63D0716BC6E71CF8171A831003482E728DFDD739, NULL);
		NullCheck(L_0);
		VirtualActionInvoker1< String_t* >::Invoke(75 /* System.Void UnityEngine.UI.Text::set_text(System.String) */, L_0, L_2);
		// }
		return;
	}
}
// System.Void Ricimi.LevelScene::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LevelScene__ctor_mB94C1948D187CC469D754521586DAD10A302C04D (LevelScene_tA6A83EA5EB8550044730C574E1AB698290FE8073* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.MusicButton::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MusicButton_Start_m2DF4520D66FB5CFBFDE3C2248A250C0644768D82 (MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisSpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8_m2100FD891B70F2F1919338CF4A2452B5E85F5A0B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_spriteSwapper = GetComponent<SpriteSwapper>();
		SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* L_0;
		L_0 = Component_GetComponent_TisSpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8_m2100FD891B70F2F1919338CF4A2452B5E85F5A0B(__this, Component_GetComponent_TisSpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8_m2100FD891B70F2F1919338CF4A2452B5E85F5A0B_RuntimeMethod_var);
		__this->___m_spriteSwapper_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_spriteSwapper_4), (void*)L_0);
		// m_on = PlayerPrefs.GetInt("music_on") == 1;
		int32_t L_1;
		L_1 = PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987(_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E, NULL);
		__this->___m_on_5 = (bool)((((int32_t)L_1) == ((int32_t)1))? 1 : 0);
		// if (!m_on)
		bool L_2 = __this->___m_on_5;
		if (L_2)
		{
			goto IL_0032;
		}
	}
	{
		// m_spriteSwapper.SwapSprite();
		SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* L_3 = __this->___m_spriteSwapper_4;
		NullCheck(L_3);
		SpriteSwapper_SwapSprite_mE2DC50C18D11F1D530793CF67A6FA6B58D31B7B5(L_3, NULL);
	}

IL_0032:
	{
		// }
		return;
	}
}
// System.Void Ricimi.MusicButton::Toggle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MusicButton_Toggle_m83C5E1BEBDBCAB63EE950F2DA63E34951BF53713 (MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m4F30DAB8E5B57E8DB6BD8C0C3BB11CCB57690C4A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7AEFF743A4AF3DCC8C577977567121A4C1CD3BCE);
		s_Il2CppMethodInitialized = true;
	}
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* G_B2_0 = NULL;
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* G_B3_1 = NULL;
	String_t* G_B5_0 = NULL;
	String_t* G_B4_0 = NULL;
	int32_t G_B6_0 = 0;
	String_t* G_B6_1 = NULL;
	{
		// m_on = !m_on;
		bool L_0 = __this->___m_on_5;
		__this->___m_on_5 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		// var backgroundAudioSource = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1;
		L_1 = GameObject_Find_m7A669B4EEC2617AB82F6E3FF007CDCD9F21DB300(_stringLiteral7AEFF743A4AF3DCC8C577977567121A4C1CD3BCE, NULL);
		NullCheck(L_1);
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_2;
		L_2 = GameObject_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m4F30DAB8E5B57E8DB6BD8C0C3BB11CCB57690C4A(L_1, GameObject_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m4F30DAB8E5B57E8DB6BD8C0C3BB11CCB57690C4A_RuntimeMethod_var);
		// backgroundAudioSource.volume = m_on ? 1 : 0;
		bool L_3 = __this->___m_on_5;
		G_B1_0 = L_2;
		if (L_3)
		{
			G_B2_0 = L_2;
			goto IL_0029;
		}
	}
	{
		G_B3_0 = 0;
		G_B3_1 = G_B1_0;
		goto IL_002a;
	}

IL_0029:
	{
		G_B3_0 = 1;
		G_B3_1 = G_B2_0;
	}

IL_002a:
	{
		NullCheck(G_B3_1);
		AudioSource_set_volume_mD902BBDBBDE0E3C148609BF3C05096148E90F2C0(G_B3_1, ((float)G_B3_0), NULL);
		// PlayerPrefs.SetInt("music_on", m_on ? 1 : 0);
		bool L_4 = __this->___m_on_5;
		G_B4_0 = _stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E;
		if (L_4)
		{
			G_B5_0 = _stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E;
			goto IL_0040;
		}
	}
	{
		G_B6_0 = 0;
		G_B6_1 = G_B4_0;
		goto IL_0041;
	}

IL_0040:
	{
		G_B6_0 = 1;
		G_B6_1 = G_B5_0;
	}

IL_0041:
	{
		PlayerPrefs_SetInt_m956D3E2DB966F20CF42F842880DDF9E2BE94D948(G_B6_1, G_B6_0, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.MusicButton::ToggleSprite()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MusicButton_ToggleSprite_mF41D35873F23AC4E7F101AA2A8AA75F738C9FE6B (MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467* __this, const RuntimeMethod* method) 
{
	{
		// m_on = !m_on;
		bool L_0 = __this->___m_on_5;
		__this->___m_on_5 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		// m_spriteSwapper.SwapSprite();
		SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* L_1 = __this->___m_spriteSwapper_4;
		NullCheck(L_1);
		SpriteSwapper_SwapSprite_mE2DC50C18D11F1D530793CF67A6FA6B58D31B7B5(L_1, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.MusicButton::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MusicButton__ctor_mE77BB02CA950618C7962845FA9C8B00B207FD1D3 (MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.MusicManager::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MusicManager_Start_m62583C53AB1103250EB8FF76B34A7CD22DD4F1F5 (MusicManager_t49777347B8E0DCB451520D9032E435E8533FC47E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisSlider_t87EA570E3D6556CABF57456C2F3873FFD86E652F_mCE53A354B934E9BDB2E8D3094F4E33EBA8FFAFBA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0766E12DBBF735D07383A0BD874E9832C568F7C8);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_musicSlider = GetComponent<Slider>();
		Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* L_0;
		L_0 = Component_GetComponent_TisSlider_t87EA570E3D6556CABF57456C2F3873FFD86E652F_mCE53A354B934E9BDB2E8D3094F4E33EBA8FFAFBA(__this, Component_GetComponent_TisSlider_t87EA570E3D6556CABF57456C2F3873FFD86E652F_mCE53A354B934E9BDB2E8D3094F4E33EBA8FFAFBA_RuntimeMethod_var);
		__this->___m_musicSlider_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_musicSlider_4), (void*)L_0);
		// m_musicSlider.value = PlayerPrefs.GetInt("music_on");
		Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* L_1 = __this->___m_musicSlider_4;
		int32_t L_2;
		L_2 = PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987(_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E, NULL);
		NullCheck(L_1);
		VirtualActionInvoker1< float >::Invoke(47 /* System.Void UnityEngine.UI.Slider::set_value(System.Single) */, L_1, ((float)L_2));
		// m_musicButton = GameObject.Find("MusicButton/Button");
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3;
		L_3 = GameObject_Find_m7A669B4EEC2617AB82F6E3FF007CDCD9F21DB300(_stringLiteral0766E12DBBF735D07383A0BD874E9832C568F7C8, NULL);
		__this->___m_musicButton_5 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_musicButton_5), (void*)L_3);
		// }
		return;
	}
}
// System.Void Ricimi.MusicManager::SwitchMusic()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MusicManager_SwitchMusic_m5916B6D413303BF59EA56977307ACEA21BFE7FCD (MusicManager_t49777347B8E0DCB451520D9032E435E8533FC47E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m4F30DAB8E5B57E8DB6BD8C0C3BB11CCB57690C4A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisMusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467_m96FF2F4E6BDD0A9AADEE7E112EB966D9DC016DBD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7AEFF743A4AF3DCC8C577977567121A4C1CD3BCE);
		s_Il2CppMethodInitialized = true;
	}
	{
		// var backgroundAudioSource = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0;
		L_0 = GameObject_Find_m7A669B4EEC2617AB82F6E3FF007CDCD9F21DB300(_stringLiteral7AEFF743A4AF3DCC8C577977567121A4C1CD3BCE, NULL);
		NullCheck(L_0);
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_1;
		L_1 = GameObject_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m4F30DAB8E5B57E8DB6BD8C0C3BB11CCB57690C4A(L_0, GameObject_GetComponent_TisAudioSource_t871AC2272F896738252F04EE949AEF5B241D3299_m4F30DAB8E5B57E8DB6BD8C0C3BB11CCB57690C4A_RuntimeMethod_var);
		// backgroundAudioSource.volume = m_musicSlider.value;
		Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* L_2 = __this->___m_musicSlider_4;
		NullCheck(L_2);
		float L_3;
		L_3 = VirtualFuncInvoker0< float >::Invoke(46 /* System.Single UnityEngine.UI.Slider::get_value() */, L_2);
		NullCheck(L_1);
		AudioSource_set_volume_mD902BBDBBDE0E3C148609BF3C05096148E90F2C0(L_1, L_3, NULL);
		// PlayerPrefs.SetInt("music_on", (int)m_musicSlider.value);
		Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* L_4 = __this->___m_musicSlider_4;
		NullCheck(L_4);
		float L_5;
		L_5 = VirtualFuncInvoker0< float >::Invoke(46 /* System.Single UnityEngine.UI.Slider::get_value() */, L_4);
		PlayerPrefs_SetInt_m956D3E2DB966F20CF42F842880DDF9E2BE94D948(_stringLiteral00DA14CF01CFA480765D26678EB540F0C95A255E, il2cpp_codegen_cast_double_to_int<int32_t>(L_5), NULL);
		// if (m_musicButton != null)
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6 = __this->___m_musicButton_5;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_6, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_7)
		{
			goto IL_0053;
		}
	}
	{
		// m_musicButton.GetComponent<MusicButton>().ToggleSprite();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_8 = __this->___m_musicButton_5;
		NullCheck(L_8);
		MusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467* L_9;
		L_9 = GameObject_GetComponent_TisMusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467_m96FF2F4E6BDD0A9AADEE7E112EB966D9DC016DBD(L_8, GameObject_GetComponent_TisMusicButton_tB6C340A4D39C9C5C2CF92E209281826D18B81467_m96FF2F4E6BDD0A9AADEE7E112EB966D9DC016DBD_RuntimeMethod_var);
		NullCheck(L_9);
		MusicButton_ToggleSprite_mF41D35873F23AC4E7F101AA2A8AA75F738C9FE6B(L_9, NULL);
	}

IL_0053:
	{
		// }
		return;
	}
}
// System.Void Ricimi.MusicManager::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MusicManager__ctor_mEFC529B9F951D0AD46D5F1A37CFB47B92578370A (MusicManager_t49777347B8E0DCB451520D9032E435E8533FC47E* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.MuteBackgroundMusic::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MuteBackgroundMusic_Awake_m86CC89B8E1FAA11C78112DB230F1D68D7AB819AB (MuteBackgroundMusic_tA2D83AF4D170E8E0B5B6CADC28C1F2390C2B9B04* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisBackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_m4B9C60B03C34C49C717FA17E9D4DBE7F8625C163_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7AEFF743A4AF3DCC8C577977567121A4C1CD3BCE);
		s_Il2CppMethodInitialized = true;
	}
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* V_0 = NULL;
	{
		// var backgroundMusic = GameObject.Find("BackgroundMusic");
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0;
		L_0 = GameObject_Find_m7A669B4EEC2617AB82F6E3FF007CDCD9F21DB300(_stringLiteral7AEFF743A4AF3DCC8C577977567121A4C1CD3BCE, NULL);
		V_0 = L_0;
		// if (backgroundMusic != null)
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1 = V_0;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_1, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_2)
		{
			goto IL_0039;
		}
	}
	{
		// m_bgMusic = backgroundMusic.GetComponent<BackgroundMusic>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3 = V_0;
		NullCheck(L_3);
		BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* L_4;
		L_4 = GameObject_GetComponent_TisBackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_m4B9C60B03C34C49C717FA17E9D4DBE7F8625C163(L_3, GameObject_GetComponent_TisBackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD_m4B9C60B03C34C49C717FA17E9D4DBE7F8625C163_RuntimeMethod_var);
		__this->___m_bgMusic_4 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_bgMusic_4), (void*)L_4);
		// if (m_bgMusic != null)
		BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* L_5 = __this->___m_bgMusic_4;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_6;
		L_6 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_5, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_6)
		{
			goto IL_0039;
		}
	}
	{
		// m_bgMusic.FadeOut();
		BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* L_7 = __this->___m_bgMusic_4;
		NullCheck(L_7);
		BackgroundMusic_FadeOut_m370AC979E7010F5A1209574DEFD5C0A34F3494B0(L_7, NULL);
	}

IL_0039:
	{
		// }
		return;
	}
}
// System.Void Ricimi.MuteBackgroundMusic::OnDestroy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MuteBackgroundMusic_OnDestroy_m37DBCCC87BEA50A055469DE8BE74E9CB322CB93C (MuteBackgroundMusic_tA2D83AF4D170E8E0B5B6CADC28C1F2390C2B9B04* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (m_bgMusic != null)
		BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* L_0 = __this->___m_bgMusic_4;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		// m_bgMusic.FadeIn();
		BackgroundMusic_t4614F09066E8D399B7B925A8BE6F0110FAC065BD* L_2 = __this->___m_bgMusic_4;
		NullCheck(L_2);
		BackgroundMusic_FadeIn_mB5A32B16E2569C9A0B591BF14E5063DC1C2BD859(L_2, NULL);
	}

IL_0019:
	{
		// }
		return;
	}
}
// System.Void Ricimi.MuteBackgroundMusic::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MuteBackgroundMusic__ctor_mF646F079389B7BB7E807DA3A5C417B1877E73E46 (MuteBackgroundMusic_tA2D83AF4D170E8E0B5B6CADC28C1F2390C2B9B04* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.PlayPopup::SetAchievedStars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayPopup_SetAchievedStars_m6B112EDB0AE29058233F47619B6DDFBAA98ACF32 (PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B* __this, int32_t ___starsObtained0, const RuntimeMethod* method) 
{
	{
		// if (starsObtained == 0)
		int32_t L_0 = ___starsObtained0;
		if (L_0)
		{
			goto IL_0037;
		}
	}
	{
		// leftStarImage.color = disabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_1 = __this->___leftStarImage_8;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = __this->___disabledColor_7;
		NullCheck(L_1);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_1, L_2);
		// middleStarImage.color = disabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = __this->___middleStarImage_9;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = __this->___disabledColor_7;
		NullCheck(L_3);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_3, L_4);
		// rightStarImage.color = disabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_5 = __this->___rightStarImage_10;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = __this->___disabledColor_7;
		NullCheck(L_5);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_5, L_6);
		return;
	}

IL_0037:
	{
		// else if (starsObtained == 1)
		int32_t L_7 = ___starsObtained0;
		if ((!(((uint32_t)L_7) == ((uint32_t)1))))
		{
			goto IL_006f;
		}
	}
	{
		// leftStarImage.color = enabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_8 = __this->___leftStarImage_8;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_9 = __this->___enabledColor_6;
		NullCheck(L_8);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_8, L_9);
		// middleStarImage.color = disabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_10 = __this->___middleStarImage_9;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_11 = __this->___disabledColor_7;
		NullCheck(L_10);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_10, L_11);
		// rightStarImage.color = disabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_12 = __this->___rightStarImage_10;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_13 = __this->___disabledColor_7;
		NullCheck(L_12);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_12, L_13);
		return;
	}

IL_006f:
	{
		// else if (starsObtained == 2)
		int32_t L_14 = ___starsObtained0;
		if ((!(((uint32_t)L_14) == ((uint32_t)2))))
		{
			goto IL_00a7;
		}
	}
	{
		// leftStarImage.color = enabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_15 = __this->___leftStarImage_8;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_16 = __this->___enabledColor_6;
		NullCheck(L_15);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_15, L_16);
		// middleStarImage.color = enabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_17 = __this->___middleStarImage_9;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_18 = __this->___enabledColor_6;
		NullCheck(L_17);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_17, L_18);
		// rightStarImage.color = disabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_19 = __this->___rightStarImage_10;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_20 = __this->___disabledColor_7;
		NullCheck(L_19);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_19, L_20);
		return;
	}

IL_00a7:
	{
		// else if (starsObtained == 3)
		int32_t L_21 = ___starsObtained0;
		if ((!(((uint32_t)L_21) == ((uint32_t)3))))
		{
			goto IL_00de;
		}
	}
	{
		// leftStarImage.color = enabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_22 = __this->___leftStarImage_8;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_23 = __this->___enabledColor_6;
		NullCheck(L_22);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_22, L_23);
		// middleStarImage.color = enabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_24 = __this->___middleStarImage_9;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_25 = __this->___enabledColor_6;
		NullCheck(L_24);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_24, L_25);
		// rightStarImage.color = enabledColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_26 = __this->___rightStarImage_10;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_27 = __this->___enabledColor_6;
		NullCheck(L_26);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_26, L_27);
	}

IL_00de:
	{
		// }
		return;
	}
}
// System.Void Ricimi.PlayPopup::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayPopup__ctor_m27064A0499C2847CE0970F7073B4360AB0705580 (PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B* __this, const RuntimeMethod* method) 
{
	{
		Popup__ctor_mD3C4BECC4CB9730A97436435F24272C69A3A2A08(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.PlayPopupOpener::OpenPopup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayPopupOpener_OpenPopup_m083366067F246345F0407E02FF5A7F19CB398C40 (PlayPopupOpener_t5A94A3B51FE3D020DC0FEDC0B71C1ADA5080CBFE* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisPlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B_m9955D8B5067AA7DBEBD6120D0AFA6D09DAFDA63B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m10D87C6E0708CA912BBB02555BF7D0FBC5D7A2B3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// var popup = Instantiate(popupPrefab) as GameObject;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = ((PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421*)__this)->___popupPrefab_4;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1;
		L_1 = Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m10D87C6E0708CA912BBB02555BF7D0FBC5D7A2B3(L_0, Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m10D87C6E0708CA912BBB02555BF7D0FBC5D7A2B3_RuntimeMethod_var);
		// popup.SetActive(true);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_2 = L_1;
		NullCheck(L_2);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_2, (bool)1, NULL);
		// popup.transform.localScale = Vector3.zero;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3 = L_2;
		NullCheck(L_3);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_4;
		L_4 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_3, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5;
		L_5 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		NullCheck(L_4);
		Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633(L_4, L_5, NULL);
		// popup.transform.SetParent(m_canvas.transform, false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6 = L_3;
		NullCheck(L_6);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_7;
		L_7 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_6, NULL);
		Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* L_8 = ((PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421*)__this)->___m_canvas_5;
		NullCheck(L_8);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_9;
		L_9 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_8, NULL);
		NullCheck(L_7);
		Transform_SetParent_m9BDD7B7476714B2D7919B10BDC22CE75C0A0A195(L_7, L_9, (bool)0, NULL);
		// var playPopup = popup.GetComponent<PlayPopup>();
		NullCheck(L_6);
		PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B* L_10;
		L_10 = GameObject_GetComponent_TisPlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B_m9955D8B5067AA7DBEBD6120D0AFA6D09DAFDA63B(L_6, GameObject_GetComponent_TisPlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B_m9955D8B5067AA7DBEBD6120D0AFA6D09DAFDA63B_RuntimeMethod_var);
		// playPopup.Open();
		PlayPopup_t16347A04589851845EB81C3A064287CFC1B62C6B* L_11 = L_10;
		NullCheck(L_11);
		Popup_Open_mDD3ECD2152C34FF982A63C25292C9294342568C0(L_11, NULL);
		// playPopup.SetAchievedStars(starsObtained);
		int32_t L_12 = __this->___starsObtained_6;
		NullCheck(L_11);
		PlayPopup_SetAchievedStars_m6B112EDB0AE29058233F47619B6DDFBAA98ACF32(L_11, L_12, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.PlayPopupOpener::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayPopupOpener__ctor_m1FE352D72CEACA8A58BF8960E9DFCED26942A24D (PlayPopupOpener_t5A94A3B51FE3D020DC0FEDC0B71C1ADA5080CBFE* __this, const RuntimeMethod* method) 
{
	{
		PopupOpener__ctor_m9DA91471383B49B98CC7FBB2AE19DD0E67347799(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.Popup::Open()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup_Open_mDD3ECD2152C34FF982A63C25292C9294342568C0 (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) 
{
	{
		// AddBackground();
		Popup_AddBackground_mE0A908E55F431C2D0523F6B485C9CE795B667C6A(__this, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.Popup::Close()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup_Close_m19A5728D529DC399A3D72A7BEAB6EBDB68A7E930 (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_m1C9FCB4BBE56BEC6BDEF6E4BA1E5DFF91614D7CE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral48419E0AC7A3C471E758A3F53E24363D7898657B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6CE02DBF10772951A436ED08602B6C21AF7A06F2);
		s_Il2CppMethodInitialized = true;
	}
	Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* V_0 = NULL;
	AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var animator = GetComponent<Animator>();
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_0;
		L_0 = Component_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_m1C9FCB4BBE56BEC6BDEF6E4BA1E5DFF91614D7CE(__this, Component_GetComponent_TisAnimator_t8A52E42AE54F76681838FE9E632683EF3952E883_m1C9FCB4BBE56BEC6BDEF6E4BA1E5DFF91614D7CE_RuntimeMethod_var);
		V_0 = L_0;
		// if (animator.GetCurrentAnimatorStateInfo(0).IsName("Open"))
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_1 = V_0;
		NullCheck(L_1);
		AnimatorStateInfo_t1F47379289C7CE7FD588FBC3BBD79A777243B6B2 L_2;
		L_2 = Animator_GetCurrentAnimatorStateInfo_mD5B526FA605F6CFBC31B7DE36740F6AD1E534CAD(L_1, 0, NULL);
		V_1 = L_2;
		bool L_3;
		L_3 = AnimatorStateInfo_IsName_mB936F493D6BDDB9372C8E9D813CE0416B002C4D0((&V_1), _stringLiteral48419E0AC7A3C471E758A3F53E24363D7898657B, NULL);
		if (!L_3)
		{
			goto IL_0028;
		}
	}
	{
		// animator.Play("Close");
		Animator_t8A52E42AE54F76681838FE9E632683EF3952E883* L_4 = V_0;
		NullCheck(L_4);
		Animator_Play_m0F6A9F84B2E256E644D56C34A7A9BD622CB00FF9(L_4, _stringLiteral6CE02DBF10772951A436ED08602B6C21AF7A06F2, NULL);
	}

IL_0028:
	{
		// RemoveBackground();
		Popup_RemoveBackground_mB4FB2F9FE36E2F38D17ADE9665565520864B61E3(__this, NULL);
		// StartCoroutine(RunPopupDestroy());
		RuntimeObject* L_5;
		L_5 = Popup_RunPopupDestroy_mB2DBEBD8D0C59F6547691501816942B0B8984EFB(__this, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_6;
		L_6 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_5, NULL);
		// }
		return;
	}
}
// System.Collections.IEnumerator Ricimi.Popup::RunPopupDestroy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Popup_RunPopupDestroy_mB2DBEBD8D0C59F6547691501816942B0B8984EFB (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* L_0 = (U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B*)il2cpp_codegen_object_new(U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CRunPopupDestroyU3Ed__4__ctor_m0737A7A1D9AC67899E272C7A4B1EA9E10D6AAB15(L_0, 0, NULL);
		U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_2 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_2), (void*)__this);
		return L_1;
	}
}
// System.Void Ricimi.Popup::AddBackground()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup_AddBackground_mE0A908E55F431C2D0523F6B485C9CE795B667C6A (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_AddComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA327C9E1CA12BC531D587E7567F2067B96E6B6A0_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEDD87ED879AA06519D891F348976F2B64886115D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFC075BC3DFE942623230E78DC9D41126E9C003CA);
		s_Il2CppMethodInitialized = true;
	}
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_0 = NULL;
	Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D V_1;
	memset((&V_1), 0, sizeof(V_1));
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* V_2 = NULL;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_3;
	memset((&V_3), 0, sizeof(V_3));
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* V_4 = NULL;
	{
		// var bgTex = new Texture2D(1, 1);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_0 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796(L_0, 1, 1, NULL);
		V_0 = L_0;
		// bgTex.SetPixel(0, 0, backgroundColor);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_1 = V_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = __this->___backgroundColor_4;
		NullCheck(L_1);
		Texture2D_SetPixel_m2CCFC5F729135D59DC4A697C2605A3FC5C8574DB(L_1, 0, 0, L_2, NULL);
		// bgTex.Apply();
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_3 = V_0;
		NullCheck(L_3);
		Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_3, NULL);
		// m_background = new GameObject("PopupBackground");
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_4 = (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)il2cpp_codegen_object_new(GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		NullCheck(L_4);
		GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88(L_4, _stringLiteralEDD87ED879AA06519D891F348976F2B64886115D, NULL);
		__this->___m_background_5 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_background_5), (void*)L_4);
		// var image = m_background.AddComponent<Image>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_5 = __this->___m_background_5;
		NullCheck(L_5);
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_6;
		L_6 = GameObject_AddComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA327C9E1CA12BC531D587E7567F2067B96E6B6A0(L_5, GameObject_AddComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA327C9E1CA12BC531D587E7567F2067B96E6B6A0_RuntimeMethod_var);
		// var rect = new Rect(0, 0, bgTex.width, bgTex.height);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_7 = V_0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_7);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_9 = V_0;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_9);
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&V_1), (0.0f), (0.0f), ((float)L_8), ((float)L_10), NULL);
		// var sprite = Sprite.Create(bgTex, rect, new Vector2(0.5f, 0.5f), 1);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_11 = V_0;
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_12 = V_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_13;
		memset((&L_13), 0, sizeof(L_13));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_13), (0.5f), (0.5f), /*hidden argument*/NULL);
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_14;
		L_14 = Sprite_Create_m95F90AD74982187C087F4FA00947045A033D0BA1(L_11, L_12, L_13, (1.0f), NULL);
		V_2 = L_14;
		// image.material.mainTexture = bgTex;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_15 = L_6;
		NullCheck(L_15);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_16;
		L_16 = VirtualFuncInvoker0< Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* >::Invoke(32 /* UnityEngine.Material UnityEngine.UI.Graphic::get_material() */, L_15);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_17 = V_0;
		NullCheck(L_16);
		Material_set_mainTexture_m389E048BA9C81B603EBF36BD792212B296317AC0(L_16, L_17, NULL);
		// image.sprite = sprite;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_18 = L_15;
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_19 = V_2;
		NullCheck(L_18);
		Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE(L_18, L_19, NULL);
		// var newColor = image.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_20 = L_18;
		NullCheck(L_20);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_21;
		L_21 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_20);
		V_3 = L_21;
		// image.color = newColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_22 = L_20;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_23 = V_3;
		NullCheck(L_22);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_22, L_23);
		// image.canvasRenderer.SetAlpha(0.0f);
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_24 = L_22;
		NullCheck(L_24);
		CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* L_25;
		L_25 = Graphic_get_canvasRenderer_m62AB727277A28728264860232642DA6EC20DEAB1(L_24, NULL);
		NullCheck(L_25);
		CanvasRenderer_SetAlpha_m97E196A1CC718DE16300954D25B4125952D7632C(L_25, (0.0f), NULL);
		// image.CrossFadeAlpha(1.0f, 0.4f, false);
		NullCheck(L_24);
		VirtualActionInvoker3< float, float, bool >::Invoke(49 /* System.Void UnityEngine.UI.Graphic::CrossFadeAlpha(System.Single,System.Single,System.Boolean) */, L_24, (1.0f), (0.400000006f), (bool)0);
		// var canvas = GameObject.Find("Canvas");
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_26;
		L_26 = GameObject_Find_m7A669B4EEC2617AB82F6E3FF007CDCD9F21DB300(_stringLiteralFC075BC3DFE942623230E78DC9D41126E9C003CA, NULL);
		V_4 = L_26;
		// m_background.transform.localScale = new Vector3(1, 1, 1);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_27 = __this->___m_background_5;
		NullCheck(L_27);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_28;
		L_28 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_27, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		memset((&L_29), 0, sizeof(L_29));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_29), (1.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		NullCheck(L_28);
		Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633(L_28, L_29, NULL);
		// m_background.GetComponent<RectTransform>().sizeDelta = canvas.GetComponent<RectTransform>().sizeDelta;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_30 = __this->___m_background_5;
		NullCheck(L_30);
		RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* L_31;
		L_31 = GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4(L_30, GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4_RuntimeMethod_var);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_32 = V_4;
		NullCheck(L_32);
		RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* L_33;
		L_33 = GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4(L_32, GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4_RuntimeMethod_var);
		NullCheck(L_33);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_34;
		L_34 = RectTransform_get_sizeDelta_m822A8493F2035677384F1540A2E9E5ACE63010BB(L_33, NULL);
		NullCheck(L_31);
		RectTransform_set_sizeDelta_mC9A980EA6036E6725EF24CEDF3EE80A9B2B50EE5(L_31, L_34, NULL);
		// m_background.transform.SetParent(canvas.transform, false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_35 = __this->___m_background_5;
		NullCheck(L_35);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_36;
		L_36 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_35, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_37 = V_4;
		NullCheck(L_37);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_38;
		L_38 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_37, NULL);
		NullCheck(L_36);
		Transform_SetParent_m9BDD7B7476714B2D7919B10BDC22CE75C0A0A195(L_36, L_38, (bool)0, NULL);
		// m_background.transform.SetSiblingIndex(transform.GetSiblingIndex());
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_39 = __this->___m_background_5;
		NullCheck(L_39);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_40;
		L_40 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_39, NULL);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_41;
		L_41 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		NullCheck(L_41);
		int32_t L_42;
		L_42 = Transform_GetSiblingIndex_m45EE497589C36D1FBED87FB802BD80A95CE68575(L_41, NULL);
		NullCheck(L_40);
		Transform_SetSiblingIndex_m8A3B81F08B93991C05BFA89ADA2146836C4FC4B2(L_40, L_42, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.Popup::RemoveBackground()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup_RemoveBackground_mB4FB2F9FE36E2F38D17ADE9665565520864B61E3 (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA59EA7D5F9133B2593F4AB70B099928BA955EE7D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* V_0 = NULL;
	{
		// var image = m_background.GetComponent<Image>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___m_background_5;
		NullCheck(L_0);
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_1;
		L_1 = GameObject_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA59EA7D5F9133B2593F4AB70B099928BA955EE7D(L_0, GameObject_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA59EA7D5F9133B2593F4AB70B099928BA955EE7D_RuntimeMethod_var);
		V_0 = L_1;
		// if (image != null)
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_2 = V_0;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_2, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		// image.CrossFadeAlpha(0.0f, 0.2f, false);
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_4 = V_0;
		NullCheck(L_4);
		VirtualActionInvoker3< float, float, bool >::Invoke(49 /* System.Void UnityEngine.UI.Graphic::CrossFadeAlpha(System.Single,System.Single,System.Boolean) */, L_4, (0.0f), (0.200000003f), (bool)0);
	}

IL_0026:
	{
		// }
		return;
	}
}
// System.Void Ricimi.Popup::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Popup__ctor_mD3C4BECC4CB9730A97436435F24272C69A3A2A08 (Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* __this, const RuntimeMethod* method) 
{
	{
		// public Color backgroundColor = new Color(10.0f / 255.0f, 10.0f / 255.0f, 10.0f / 255.0f, 0.6f);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		memset((&L_0), 0, sizeof(L_0));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_0), (0.0392156877f), (0.0392156877f), (0.0392156877f), (0.600000024f), /*hidden argument*/NULL);
		__this->___backgroundColor_4 = L_0;
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.Popup/<RunPopupDestroy>d__4::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunPopupDestroyU3Ed__4__ctor_m0737A7A1D9AC67899E272C7A4B1EA9E10D6AAB15 (U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->___U3CU3E1__state_0 = L_0;
		return;
	}
}
// System.Void Ricimi.Popup/<RunPopupDestroy>d__4::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunPopupDestroyU3Ed__4_System_IDisposable_Dispose_m490EE3D182034360E12BDBC134B2E785C4DF1C9F (U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean Ricimi.Popup/<RunPopupDestroy>d__4::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CRunPopupDestroyU3Ed__4_MoveNext_mB07B817861B4D377BA31C2FA0B5EFA32627A2FFC (U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* V_1 = NULL;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* L_1 = __this->___U3CU3E4__this_2;
		V_1 = L_1;
		int32_t L_2 = V_0;
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)1)))
		{
			goto IL_0037;
		}
	}
	{
		return (bool)0;
	}

IL_0017:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// yield return new WaitForSeconds(0.5f);
		WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3* L_4 = (WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3*)il2cpp_codegen_object_new(WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var);
		NullCheck(L_4);
		WaitForSeconds__ctor_m579F95BADEDBAB4B3A7E302C6EE3995926EF2EFC(L_4, (0.5f), NULL);
		__this->___U3CU3E2__current_1 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_4);
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_0037:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// Destroy(m_background);
		Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* L_5 = V_1;
		NullCheck(L_5);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6 = L_5->___m_background_5;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB(L_6, NULL);
		// Destroy(gameObject);
		Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* L_7 = V_1;
		NullCheck(L_7);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_8;
		L_8 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(L_7, NULL);
		Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB(L_8, NULL);
		// }
		return (bool)0;
	}
}
// System.Object Ricimi.Popup/<RunPopupDestroy>d__4::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CRunPopupDestroyU3Ed__4_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_m5BCEC9C8C22A6B8EA2CDD09A92266637A57E06C4 (U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void Ricimi.Popup/<RunPopupDestroy>d__4::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunPopupDestroyU3Ed__4_System_Collections_IEnumerator_Reset_m0A5A6719D2A873657BB745E628FF98748914EBB7 (U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CRunPopupDestroyU3Ed__4_System_Collections_IEnumerator_Reset_m0A5A6719D2A873657BB745E628FF98748914EBB7_RuntimeMethod_var)));
	}
}
// System.Object Ricimi.Popup/<RunPopupDestroy>d__4::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CRunPopupDestroyU3Ed__4_System_Collections_IEnumerator_get_Current_m45027D60BEC3D953FEA4D64FB2B91850A78A8D6D (U3CRunPopupDestroyU3Ed__4_tB4119C0E168BA4324BE56FE3876FDBFE7037054B* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.PopupOpener::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PopupOpener_Start_m0CAF7C2CB0EFE5312D2ACE0C70AD24620FE7443B (PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_mE5A2711FA84F57F5EA0876DB106B1A146956CEFE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFC075BC3DFE942623230E78DC9D41126E9C003CA);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0;
		L_0 = GameObject_Find_m7A669B4EEC2617AB82F6E3FF007CDCD9F21DB300(_stringLiteralFC075BC3DFE942623230E78DC9D41126E9C003CA, NULL);
		NullCheck(L_0);
		Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* L_1;
		L_1 = GameObject_GetComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_mE5A2711FA84F57F5EA0876DB106B1A146956CEFE(L_0, GameObject_GetComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_mE5A2711FA84F57F5EA0876DB106B1A146956CEFE_RuntimeMethod_var);
		__this->___m_canvas_5 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_canvas_5), (void*)L_1);
		// }
		return;
	}
}
// System.Void Ricimi.PopupOpener::OpenPopup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PopupOpener_OpenPopup_mDF9888A0386801781DC9F5D1C660F07A3C284197 (PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisPopup_tC1E66E522EA4DBB41FC326155A497B0D820337F8_m9E3A528EE1D81D2B08C1650C99FFE3D108BD89B9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m10D87C6E0708CA912BBB02555BF7D0FBC5D7A2B3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// var popup = Instantiate(popupPrefab) as GameObject;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___popupPrefab_4;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1;
		L_1 = Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m10D87C6E0708CA912BBB02555BF7D0FBC5D7A2B3(L_0, Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m10D87C6E0708CA912BBB02555BF7D0FBC5D7A2B3_RuntimeMethod_var);
		// popup.SetActive(true);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_2 = L_1;
		NullCheck(L_2);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_2, (bool)1, NULL);
		// popup.transform.localScale = Vector3.zero;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3 = L_2;
		NullCheck(L_3);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_4;
		L_4 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_3, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5;
		L_5 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		NullCheck(L_4);
		Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633(L_4, L_5, NULL);
		// popup.transform.SetParent(m_canvas.transform, false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6 = L_3;
		NullCheck(L_6);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_7;
		L_7 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_6, NULL);
		Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* L_8 = __this->___m_canvas_5;
		NullCheck(L_8);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_9;
		L_9 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_8, NULL);
		NullCheck(L_7);
		Transform_SetParent_m9BDD7B7476714B2D7919B10BDC22CE75C0A0A195(L_7, L_9, (bool)0, NULL);
		// popup.GetComponent<Popup>().Open();
		NullCheck(L_6);
		Popup_tC1E66E522EA4DBB41FC326155A497B0D820337F8* L_10;
		L_10 = GameObject_GetComponent_TisPopup_tC1E66E522EA4DBB41FC326155A497B0D820337F8_m9E3A528EE1D81D2B08C1650C99FFE3D108BD89B9(L_6, GameObject_GetComponent_TisPopup_tC1E66E522EA4DBB41FC326155A497B0D820337F8_m9E3A528EE1D81D2B08C1650C99FFE3D108BD89B9_RuntimeMethod_var);
		NullCheck(L_10);
		Popup_Open_mDD3ECD2152C34FF982A63C25292C9294342568C0(L_10, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.PopupOpener::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PopupOpener__ctor_m9DA91471383B49B98CC7FBB2AE19DD0E67347799 (PopupOpener_t1E1FD8218A43E61F9D3015A21A02050EABA59421* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.SceneTransition::PerformTransition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneTransition_PerformTransition_m16F0B006A34E07CBDF27C505A2F93505AA9D7D80 (SceneTransition_tCB626AD8A4C6B1DF87F1F55575D36D043C8C6A69* __this, const RuntimeMethod* method) 
{
	{
		// Transition.LoadLevel(scene, duration, color);
		String_t* L_0 = __this->___scene_4;
		float L_1 = __this->___duration_5;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = __this->___color_6;
		Transition_LoadLevel_m91F593BEC887DF1F9C68F093CB0A021A77A7592D(L_0, L_1, L_2, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.SceneTransition::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneTransition__ctor_m6DFDEC613B36E8D63438826A4EB8B7C3B1F04D4A (SceneTransition_tCB626AD8A4C6B1DF87F1F55575D36D043C8C6A69* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral508A0D658A13F703F966F8F692AC070E724F5C92);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public string scene = "<Insert scene name>";
		__this->___scene_4 = _stringLiteral508A0D658A13F703F966F8F692AC070E724F5C92;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___scene_4), (void*)_stringLiteral508A0D658A13F703F966F8F692AC070E724F5C92);
		// public float duration = 1.0f;
		__this->___duration_5 = (1.0f);
		// public Color color = Color.black;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		L_0 = Color_get_black_mB50217951591A045844C61E7FF31EEE3FEF16737_inline(NULL);
		__this->___color_6 = L_0;
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.SoundButton::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SoundButton_Start_mBA31FC5FD3A0D09878DDFC2EB04374A97C4480D8 (SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisSpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8_m2100FD891B70F2F1919338CF4A2452B5E85F5A0B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_spriteSwapper = GetComponent<SpriteSwapper>();
		SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* L_0;
		L_0 = Component_GetComponent_TisSpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8_m2100FD891B70F2F1919338CF4A2452B5E85F5A0B(__this, Component_GetComponent_TisSpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8_m2100FD891B70F2F1919338CF4A2452B5E85F5A0B_RuntimeMethod_var);
		__this->___m_spriteSwapper_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_spriteSwapper_4), (void*)L_0);
		// m_on = PlayerPrefs.GetInt("sound_on") == 1;
		int32_t L_1;
		L_1 = PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987(_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD, NULL);
		__this->___m_on_5 = (bool)((((int32_t)L_1) == ((int32_t)1))? 1 : 0);
		// if (!m_on)
		bool L_2 = __this->___m_on_5;
		if (L_2)
		{
			goto IL_0032;
		}
	}
	{
		// m_spriteSwapper.SwapSprite();
		SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* L_3 = __this->___m_spriteSwapper_4;
		NullCheck(L_3);
		SpriteSwapper_SwapSprite_mE2DC50C18D11F1D530793CF67A6FA6B58D31B7B5(L_3, NULL);
	}

IL_0032:
	{
		// }
		return;
	}
}
// System.Void Ricimi.SoundButton::Toggle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SoundButton_Toggle_m696AAF99D341F7BA815B7E1D9FE6272066B6D6E3 (SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD);
		s_Il2CppMethodInitialized = true;
	}
	int32_t G_B3_0 = 0;
	String_t* G_B5_0 = NULL;
	String_t* G_B4_0 = NULL;
	int32_t G_B6_0 = 0;
	String_t* G_B6_1 = NULL;
	{
		// m_on = !m_on;
		bool L_0 = __this->___m_on_5;
		__this->___m_on_5 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		// AudioListener.volume = m_on ? 1 : 0;
		bool L_1 = __this->___m_on_5;
		if (L_1)
		{
			goto IL_001a;
		}
	}
	{
		G_B3_0 = 0;
		goto IL_001b;
	}

IL_001a:
	{
		G_B3_0 = 1;
	}

IL_001b:
	{
		AudioListener_set_volume_m72BAF2D558A5449091A59630EBF48095DEB4C721(((float)G_B3_0), NULL);
		// PlayerPrefs.SetInt("sound_on", m_on ? 1 : 0);
		bool L_2 = __this->___m_on_5;
		G_B4_0 = _stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD;
		if (L_2)
		{
			G_B5_0 = _stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD;
			goto IL_0031;
		}
	}
	{
		G_B6_0 = 0;
		G_B6_1 = G_B4_0;
		goto IL_0032;
	}

IL_0031:
	{
		G_B6_0 = 1;
		G_B6_1 = G_B5_0;
	}

IL_0032:
	{
		PlayerPrefs_SetInt_m956D3E2DB966F20CF42F842880DDF9E2BE94D948(G_B6_1, G_B6_0, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.SoundButton::ToggleSprite()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SoundButton_ToggleSprite_mBB9667A5EBCF46A07B72852273ADFC694C52045A (SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554* __this, const RuntimeMethod* method) 
{
	{
		// m_on = !m_on;
		bool L_0 = __this->___m_on_5;
		__this->___m_on_5 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		// m_spriteSwapper.SwapSprite();
		SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* L_1 = __this->___m_spriteSwapper_4;
		NullCheck(L_1);
		SpriteSwapper_SwapSprite_mE2DC50C18D11F1D530793CF67A6FA6B58D31B7B5(L_1, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.SoundButton::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SoundButton__ctor_m28EF5EAC0CC94AC9FFFE7A5070D3C30355B91D9C (SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.SoundManager::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SoundManager_Start_m1ACDBE860AB35F4349D868B68669158237481AD0 (SoundManager_t11FAAFE4BA02BF7347C1BC24FCCF11EC1DE8A7E8* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisSlider_t87EA570E3D6556CABF57456C2F3873FFD86E652F_mCE53A354B934E9BDB2E8D3094F4E33EBA8FFAFBA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA68C68B0226E4226FF92C67906FD8F4309260CF1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_soundSlider = GetComponent<Slider>();
		Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* L_0;
		L_0 = Component_GetComponent_TisSlider_t87EA570E3D6556CABF57456C2F3873FFD86E652F_mCE53A354B934E9BDB2E8D3094F4E33EBA8FFAFBA(__this, Component_GetComponent_TisSlider_t87EA570E3D6556CABF57456C2F3873FFD86E652F_mCE53A354B934E9BDB2E8D3094F4E33EBA8FFAFBA_RuntimeMethod_var);
		__this->___m_soundSlider_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_soundSlider_4), (void*)L_0);
		// m_soundSlider.value = PlayerPrefs.GetInt("sound_on");
		Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* L_1 = __this->___m_soundSlider_4;
		int32_t L_2;
		L_2 = PlayerPrefs_GetInt_m4D859DBEABAD3FB406C94485A0B2638A0C7F2987(_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD, NULL);
		NullCheck(L_1);
		VirtualActionInvoker1< float >::Invoke(47 /* System.Void UnityEngine.UI.Slider::set_value(System.Single) */, L_1, ((float)L_2));
		// m_soundButton = GameObject.Find("SoundButton/Button");
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3;
		L_3 = GameObject_Find_m7A669B4EEC2617AB82F6E3FF007CDCD9F21DB300(_stringLiteralA68C68B0226E4226FF92C67906FD8F4309260CF1, NULL);
		__this->___m_soundButton_5 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_soundButton_5), (void*)L_3);
		// }
		return;
	}
}
// System.Void Ricimi.SoundManager::SwitchSound()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SoundManager_SwitchSound_m680B89D05DD8A266D1B1B57F7DAC80E6CD3992B9 (SoundManager_t11FAAFE4BA02BF7347C1BC24FCCF11EC1DE8A7E8* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisSoundButton_t3E516F24DF47C4E25F3870D7687C058064176554_mA298D7DA24E33499C8038ADD34ED3BC16E96B090_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD);
		s_Il2CppMethodInitialized = true;
	}
	{
		// AudioListener.volume = m_soundSlider.value;
		Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* L_0 = __this->___m_soundSlider_4;
		NullCheck(L_0);
		float L_1;
		L_1 = VirtualFuncInvoker0< float >::Invoke(46 /* System.Single UnityEngine.UI.Slider::get_value() */, L_0);
		AudioListener_set_volume_m72BAF2D558A5449091A59630EBF48095DEB4C721(L_1, NULL);
		// PlayerPrefs.SetInt("sound_on", (int)m_soundSlider.value);
		Slider_t87EA570E3D6556CABF57456C2F3873FFD86E652F* L_2 = __this->___m_soundSlider_4;
		NullCheck(L_2);
		float L_3;
		L_3 = VirtualFuncInvoker0< float >::Invoke(46 /* System.Single UnityEngine.UI.Slider::get_value() */, L_2);
		PlayerPrefs_SetInt_m956D3E2DB966F20CF42F842880DDF9E2BE94D948(_stringLiteralEA313F262C8F7D148AD79878612FFA493CA9C5AD, il2cpp_codegen_cast_double_to_int<int32_t>(L_3), NULL);
		// if (m_soundButton != null)
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_4 = __this->___m_soundButton_5;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_5;
		L_5 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_4, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_5)
		{
			goto IL_0044;
		}
	}
	{
		// m_soundButton.GetComponent<SoundButton>().ToggleSprite();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6 = __this->___m_soundButton_5;
		NullCheck(L_6);
		SoundButton_t3E516F24DF47C4E25F3870D7687C058064176554* L_7;
		L_7 = GameObject_GetComponent_TisSoundButton_t3E516F24DF47C4E25F3870D7687C058064176554_mA298D7DA24E33499C8038ADD34ED3BC16E96B090(L_6, GameObject_GetComponent_TisSoundButton_t3E516F24DF47C4E25F3870D7687C058064176554_mA298D7DA24E33499C8038ADD34ED3BC16E96B090_RuntimeMethod_var);
		NullCheck(L_7);
		SoundButton_ToggleSprite_mBB9667A5EBCF46A07B72852273ADFC694C52045A(L_7, NULL);
	}

IL_0044:
	{
		// }
		return;
	}
}
// System.Void Ricimi.SoundManager::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SoundManager__ctor_mA1F3BC4611775FCBBDA4B549B476B7431CE66F77 (SoundManager_t11FAAFE4BA02BF7347C1BC24FCCF11EC1DE8A7E8* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.SpinWheel::Spin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpinWheel_Spin_m0EA0F2CE64A85EB9D310426C5B075896550A80E0 (SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* __this, const RuntimeMethod* method) 
{
	{
		// if (!m_spinning)
		bool L_0 = __this->___m_spinning_5;
		if (L_0)
		{
			goto IL_0015;
		}
	}
	{
		// StartCoroutine(DoSpin());
		RuntimeObject* L_1;
		L_1 = SpinWheel_DoSpin_m579F3C76866BA086536D8BF5CA51D7F6234E2499(__this, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_2;
		L_2 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_1, NULL);
	}

IL_0015:
	{
		// }
		return;
	}
}
// System.Collections.IEnumerator Ricimi.SpinWheel::DoSpin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* SpinWheel_DoSpin_m579F3C76866BA086536D8BF5CA51D7F6234E2499 (SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* L_0 = (U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02*)il2cpp_codegen_object_new(U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CDoSpinU3Ed__3__ctor_mFB2287FE370B3BA99BD4BD90B98133AE2AF38C5A(L_0, 0, NULL);
		U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_2 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_2), (void*)__this);
		return L_1;
	}
}
// System.Void Ricimi.SpinWheel::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpinWheel__ctor_m2D4A744CBC43251A96EE4F5B003F17174FC8307D (SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.SpinWheel/<DoSpin>d__3::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CDoSpinU3Ed__3__ctor_mFB2287FE370B3BA99BD4BD90B98133AE2AF38C5A (U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->___U3CU3E1__state_0 = L_0;
		return;
	}
}
// System.Void Ricimi.SpinWheel/<DoSpin>d__3::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CDoSpinU3Ed__3_System_IDisposable_Dispose_m80008C0F4C2BC9AE56375157A0B232473DB7517A (U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean Ricimi.SpinWheel/<DoSpin>d__3::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CDoSpinU3Ed__3_MoveNext_mF0ECA9BC06CCE5543B29108D53971223D563C035 (U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* V_1 = NULL;
	float V_2 = 0.0f;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* L_1 = __this->___U3CU3E4__this_2;
		V_1 = L_1;
		int32_t L_2 = V_0;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)1)))
		{
			goto IL_00c9;
		}
	}
	{
		return (bool)0;
	}

IL_001a:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// m_spinning = true;
		SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* L_4 = V_1;
		NullCheck(L_4);
		L_4->___m_spinning_5 = (bool)1;
		// var timer = 0.0f;
		__this->___U3CtimerU3E5__2_3 = (0.0f);
		// var startAngle = transform.eulerAngles.z;
		SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* L_5 = V_1;
		NullCheck(L_5);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_6;
		L_6 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_5, NULL);
		NullCheck(L_6);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Transform_get_eulerAngles_mCAAF48EFCF628F1ED91C2FFE75A4FD19C039DD6A(L_6, NULL);
		float L_8 = L_7.___z_4;
		__this->___U3CstartAngleU3E5__3_4 = L_8;
		// var time = 3.0f;
		__this->___U3CtimeU3E5__4_5 = (3.0f);
		// var maxAngle = 270.0f;
		__this->___U3CmaxAngleU3E5__5_6 = (270.0f);
		goto IL_00d0;
	}

IL_0061:
	{
		// var angle = AnimationCurve.Evaluate(timer / time) * maxAngle;
		SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* L_9 = V_1;
		NullCheck(L_9);
		AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* L_10 = L_9->___AnimationCurve_4;
		float L_11 = __this->___U3CtimerU3E5__2_3;
		float L_12 = __this->___U3CtimeU3E5__4_5;
		NullCheck(L_10);
		float L_13;
		L_13 = AnimationCurve_Evaluate_m50B857043DE251A186032ADBCBB4CEF817F4EE3C(L_10, ((float)(L_11/L_12)), NULL);
		float L_14 = __this->___U3CmaxAngleU3E5__5_6;
		V_2 = ((float)il2cpp_codegen_multiply(L_13, L_14));
		// transform.eulerAngles = new Vector3(0.0f, 0.0f, angle + startAngle);
		SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* L_15 = V_1;
		NullCheck(L_15);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_16;
		L_16 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_15, NULL);
		float L_17 = V_2;
		float L_18 = __this->___U3CstartAngleU3E5__3_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19;
		memset((&L_19), 0, sizeof(L_19));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_19), (0.0f), (0.0f), ((float)il2cpp_codegen_add(L_17, L_18)), /*hidden argument*/NULL);
		NullCheck(L_16);
		Transform_set_eulerAngles_m9F0BC484A7915A51FAB87230644229B75BACA004(L_16, L_19, NULL);
		// timer += Time.deltaTime;
		float L_20 = __this->___U3CtimerU3E5__2_3;
		float L_21;
		L_21 = Time_get_deltaTime_mC3195000401F0FD167DD2F948FD2BC58330D0865(NULL);
		__this->___U3CtimerU3E5__2_3 = ((float)il2cpp_codegen_add(L_20, L_21));
		// yield return new WaitForEndOfFrame();
		WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663* L_22 = (WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663*)il2cpp_codegen_object_new(WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		NullCheck(L_22);
		WaitForEndOfFrame__ctor_m4AF7E576C01E6B04443BB898B1AE5D645F7D45AB(L_22, NULL);
		__this->___U3CU3E2__current_1 = L_22;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_22);
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_00c9:
	{
		__this->___U3CU3E1__state_0 = (-1);
	}

IL_00d0:
	{
		// while (timer < time)
		float L_23 = __this->___U3CtimerU3E5__2_3;
		float L_24 = __this->___U3CtimeU3E5__4_5;
		if ((((float)L_23) < ((float)L_24)))
		{
			goto IL_0061;
		}
	}
	{
		// transform.eulerAngles = new Vector3(0.0f, 0.0f, maxAngle + startAngle);
		SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* L_25 = V_1;
		NullCheck(L_25);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_26;
		L_26 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_25, NULL);
		float L_27 = __this->___U3CmaxAngleU3E5__5_6;
		float L_28 = __this->___U3CstartAngleU3E5__3_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29;
		memset((&L_29), 0, sizeof(L_29));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_29), (0.0f), (0.0f), ((float)il2cpp_codegen_add(L_27, L_28)), /*hidden argument*/NULL);
		NullCheck(L_26);
		Transform_set_eulerAngles_m9F0BC484A7915A51FAB87230644229B75BACA004(L_26, L_29, NULL);
		// m_spinning = false;
		SpinWheel_t18F7E6B885B8AC21DD973711341DCCEEBA09B225* L_30 = V_1;
		NullCheck(L_30);
		L_30->___m_spinning_5 = (bool)0;
		// }
		return (bool)0;
	}
}
// System.Object Ricimi.SpinWheel/<DoSpin>d__3::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CDoSpinU3Ed__3_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_m1A8D9133813B216F8BBF146AAAA3AD90DA665FB2 (U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void Ricimi.SpinWheel/<DoSpin>d__3::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CDoSpinU3Ed__3_System_Collections_IEnumerator_Reset_mD314362705FD0647965F859DF9224330E37D9D23 (U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CDoSpinU3Ed__3_System_Collections_IEnumerator_Reset_mD314362705FD0647965F859DF9224330E37D9D23_RuntimeMethod_var)));
	}
}
// System.Object Ricimi.SpinWheel/<DoSpin>d__3::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CDoSpinU3Ed__3_System_Collections_IEnumerator_get_Current_m8E20A8BA778DBF2210DD5A04B5233F8DA80AFCEE (U3CDoSpinU3Ed__3_t4D8E15BA3A492A68684F0E3DCE3FED65C3678F02* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.SpriteSwapper::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpriteSwapper_Awake_m9B418EE03F6C85717D1847ECB8B7199E8A618288 (SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mE74EE63C85A63FC34DCFC631BC229207B420BC79_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_image = GetComponent<Image>();
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_0;
		L_0 = Component_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mE74EE63C85A63FC34DCFC631BC229207B420BC79(__this, Component_GetComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mE74EE63C85A63FC34DCFC631BC229207B420BC79_RuntimeMethod_var);
		__this->___m_image_7 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_image_7), (void*)L_0);
		// }
		return;
	}
}
// System.Void Ricimi.SpriteSwapper::SwapSprite()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpriteSwapper_SwapSprite_mE2DC50C18D11F1D530793CF67A6FA6B58D31B7B5 (SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* __this, const RuntimeMethod* method) 
{
	{
		// if (m_swapped)
		bool L_0 = __this->___m_swapped_6;
		if (!L_0)
		{
			goto IL_0021;
		}
	}
	{
		// m_swapped = false;
		__this->___m_swapped_6 = (bool)0;
		// m_image.sprite = disabledSprite;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_1 = __this->___m_image_7;
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_2 = __this->___disabledSprite_5;
		NullCheck(L_1);
		Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE(L_1, L_2, NULL);
		return;
	}

IL_0021:
	{
		// m_swapped = true;
		__this->___m_swapped_6 = (bool)1;
		// m_image.sprite = enabledSprite;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = __this->___m_image_7;
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_4 = __this->___enabledSprite_4;
		NullCheck(L_3);
		Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE(L_3, L_4, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.SpriteSwapper::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpriteSwapper__ctor_mFB136FF22EE190ADC5F5FDC0E21709891143A63B (SpriteSwapper_t075AA7837C2529F9A52E93D7019A157338C3ABD8* __this, const RuntimeMethod* method) 
{
	{
		// private bool m_swapped = true;
		__this->___m_swapped_6 = (bool)1;
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Ricimi.TintedButton/ButtonClickedEvent Ricimi.TintedButton::get_onClick()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* TintedButton_get_onClick_mAFBD9F0D394473A966A081E5CDA197A800C35CDC (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) 
{
	{
		// get { return m_OnClick; }
		ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* L_0 = __this->___m_OnClick_4;
		return L_0;
	}
}
// System.Void Ricimi.TintedButton::set_onClick(Ricimi.TintedButton/ButtonClickedEvent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_set_onClick_m83603391181B7551A5F8429D7A1E0A28473EC13F (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* ___value0, const RuntimeMethod* method) 
{
	{
		// set { m_OnClick = value; }
		ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* L_0 = ___value0;
		__this->___m_OnClick_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_OnClick_4), (void*)L_0);
		// set { m_OnClick = value; }
		return;
	}
}
// System.Void Ricimi.TintedButton::OnPointerEnter(UnityEngine.EventSystems.PointerEventData)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_OnPointerEnter_m3C297A921CA60F07FC3B7EDB818AB505FA71D569 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* ___eventData0, const RuntimeMethod* method) 
{
	{
		// if (eventData.button != PointerEventData.InputButton.Left)
		PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* L_0 = ___eventData0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = PointerEventData_get_button_mA8CBDAF2E16927E6952BC60040D56630BCC95B0B_inline(L_0, NULL);
		if (!L_1)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// m_pointerInside = true;
		__this->___m_pointerInside_6 = (bool)1;
		// if (m_pointerPressed)
		bool L_2 = __this->___m_pointerPressed_7;
		if (!L_2)
		{
			goto IL_001e;
		}
	}
	{
		// Press();
		TintedButton_Press_m18C49B8D2DA957BA2A4099819E9D04EDFD4DA2F8(__this, NULL);
	}

IL_001e:
	{
		// }
		return;
	}
}
// System.Void Ricimi.TintedButton::OnPointerExit(UnityEngine.EventSystems.PointerEventData)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_OnPointerExit_m54F94098F0EDD212F7C61FDD6753D2C034AE6B1D (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* ___eventData0, const RuntimeMethod* method) 
{
	{
		// if (eventData.button != PointerEventData.InputButton.Left)
		PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* L_0 = ___eventData0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = PointerEventData_get_button_mA8CBDAF2E16927E6952BC60040D56630BCC95B0B_inline(L_0, NULL);
		if (!L_1)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// m_pointerInside = false;
		__this->___m_pointerInside_6 = (bool)0;
		// if (m_pointerPressed)
		bool L_2 = __this->___m_pointerPressed_7;
		if (!L_2)
		{
			goto IL_001e;
		}
	}
	{
		// Unpress();
		TintedButton_Unpress_mBB8BAB07FB858376C54E8DEF040B8F45B91257E2(__this, NULL);
	}

IL_001e:
	{
		// }
		return;
	}
}
// System.Void Ricimi.TintedButton::OnPointerUp(UnityEngine.EventSystems.PointerEventData)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_OnPointerUp_m8D16413FE96D148332EEB154E6EE72DF75EC0066 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* ___eventData0, const RuntimeMethod* method) 
{
	{
		// if (eventData.button != PointerEventData.InputButton.Left)
		PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* L_0 = ___eventData0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = PointerEventData_get_button_mA8CBDAF2E16927E6952BC60040D56630BCC95B0B_inline(L_0, NULL);
		if (!L_1)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// m_pointerPressed = false;
		__this->___m_pointerPressed_7 = (bool)0;
		// if (m_pointerInside)
		bool L_2 = __this->___m_pointerInside_6;
		if (!L_2)
		{
			goto IL_0029;
		}
	}
	{
		// Unpress();
		TintedButton_Unpress_mBB8BAB07FB858376C54E8DEF040B8F45B91257E2(__this, NULL);
		// m_OnClick.Invoke();
		ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* L_3 = __this->___m_OnClick_4;
		NullCheck(L_3);
		UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2(L_3, NULL);
	}

IL_0029:
	{
		// }
		return;
	}
}
// System.Void Ricimi.TintedButton::OnPointerDown(UnityEngine.EventSystems.PointerEventData)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_OnPointerDown_mCFA2EB8B85BC2141E59ECB40FE4B79E27E1146F6 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* ___eventData0, const RuntimeMethod* method) 
{
	{
		// if (eventData.button != PointerEventData.InputButton.Left)
		PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* L_0 = ___eventData0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = PointerEventData_get_button_mA8CBDAF2E16927E6952BC60040D56630BCC95B0B_inline(L_0, NULL);
		if (!L_1)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// m_pointerPressed = true;
		__this->___m_pointerPressed_7 = (bool)1;
		// if (m_pointerInside)
		bool L_2 = __this->___m_pointerInside_6;
		if (!L_2)
		{
			goto IL_001e;
		}
	}
	{
		// Press();
		TintedButton_Press_m18C49B8D2DA957BA2A4099819E9D04EDFD4DA2F8(__this, NULL);
	}

IL_001e:
	{
		// }
		return;
	}
}
// System.Void Ricimi.TintedButton::Press()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_Press_m18C49B8D2DA957BA2A4099819E9D04EDFD4DA2F8 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) 
{
	{
		// if (!IsActive())
		bool L_0;
		L_0 = VirtualFuncInvoker0< bool >::Invoke(9 /* System.Boolean UnityEngine.EventSystems.UIBehaviour::IsActive() */, __this);
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// Darken();
		TintedButton_Darken_mC049412477087BA57C8BB4903E4016A0636062A9(__this, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.TintedButton::Unpress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_Unpress_mBB8BAB07FB858376C54E8DEF040B8F45B91257E2 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) 
{
	{
		// if (!IsActive())
		bool L_0;
		L_0 = VirtualFuncInvoker0< bool >::Invoke(9 /* System.Boolean UnityEngine.EventSystems.UIBehaviour::IsActive() */, __this);
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// Brighten();
		TintedButton_Brighten_mFD95A1269BD81BA91498A716E4A819FD3A522B68(__this, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.TintedButton::Darken()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_Darken_mC049412477087BA57C8BB4903E4016A0636062A9 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_m755CF1DB6A65043AC21E6F3153B9060B358DCC64_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* V_0 = NULL;
	int32_t V_1 = 0;
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* V_2 = NULL;
	{
		// var images = GetComponentsInChildren<Image>();
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_0;
		L_0 = Component_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_m755CF1DB6A65043AC21E6F3153B9060B358DCC64(__this, Component_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_m755CF1DB6A65043AC21E6F3153B9060B358DCC64_RuntimeMethod_var);
		// foreach (var image in images)
		V_0 = L_0;
		V_1 = 0;
		goto IL_0021;
	}

IL_000b:
	{
		// foreach (var image in images)
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_1 = V_0;
		int32_t L_2 = V_1;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_2 = L_4;
		// StartCoroutine(DarkenColor(image));
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_5 = V_2;
		RuntimeObject* L_6;
		L_6 = TintedButton_DarkenColor_m12D94451464E68FD85D025C020BFDA5D103159AF(__this, L_5, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_7;
		L_7 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_6, NULL);
		int32_t L_8 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0021:
	{
		// foreach (var image in images)
		int32_t L_9 = V_1;
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_10 = V_0;
		NullCheck(L_10);
		if ((((int32_t)L_9) < ((int32_t)((int32_t)(((RuntimeArray*)L_10)->max_length)))))
		{
			goto IL_000b;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Ricimi.TintedButton::Brighten()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton_Brighten_mFD95A1269BD81BA91498A716E4A819FD3A522B68 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_m755CF1DB6A65043AC21E6F3153B9060B358DCC64_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* V_0 = NULL;
	int32_t V_1 = 0;
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* V_2 = NULL;
	{
		// var images = GetComponentsInChildren<Image>();
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_0;
		L_0 = Component_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_m755CF1DB6A65043AC21E6F3153B9060B358DCC64(__this, Component_GetComponentsInChildren_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_m755CF1DB6A65043AC21E6F3153B9060B358DCC64_RuntimeMethod_var);
		// foreach (var image in images)
		V_0 = L_0;
		V_1 = 0;
		goto IL_0021;
	}

IL_000b:
	{
		// foreach (var image in images)
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_1 = V_0;
		int32_t L_2 = V_1;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_2 = L_4;
		// StartCoroutine(BrightenColor(image));
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_5 = V_2;
		RuntimeObject* L_6;
		L_6 = TintedButton_BrightenColor_mE7076B94B4B57A99C6D42C65B6903BBCE215D072(__this, L_5, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_7;
		L_7 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_6, NULL);
		int32_t L_8 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0021:
	{
		// foreach (var image in images)
		int32_t L_9 = V_1;
		ImageU5BU5D_t8869694C217655DA7B1315DC02C80F1308B78B78* L_10 = V_0;
		NullCheck(L_10);
		if ((((int32_t)L_9) < ((int32_t)((int32_t)(((RuntimeArray*)L_10)->max_length)))))
		{
			goto IL_000b;
		}
	}
	{
		// }
		return;
	}
}
// System.Collections.IEnumerator Ricimi.TintedButton::DarkenColor(UnityEngine.UI.Image)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* TintedButton_DarkenColor_m12D94451464E68FD85D025C020BFDA5D103159AF (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___image0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* L_0 = (U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A*)il2cpp_codegen_object_new(U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CDarkenColorU3Ed__16__ctor_mD8802F5C9B230BAFFBCA94B51C9508FE380A0228(L_0, 0, NULL);
		U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* L_1 = L_0;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_2 = ___image0;
		NullCheck(L_1);
		L_1->___image_2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___image_2), (void*)L_2);
		return L_1;
	}
}
// System.Collections.IEnumerator Ricimi.TintedButton::BrightenColor(UnityEngine.UI.Image)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* TintedButton_BrightenColor_mE7076B94B4B57A99C6D42C65B6903BBCE215D072 (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___image0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* L_0 = (U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B*)il2cpp_codegen_object_new(U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CBrightenColorU3Ed__17__ctor_mF812D99D9D7073067A921DA7A9B4FEC06EB8D40D(L_0, 0, NULL);
		U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* L_1 = L_0;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_2 = ___image0;
		NullCheck(L_1);
		L_1->___image_2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___image_2), (void*)L_2);
		return L_1;
	}
}
// System.Void Ricimi.TintedButton::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TintedButton__ctor_mF0187539566B19B6966563F3DB3B52D91F66569D (TintedButton_t0615BC5352A35F4E25617C5422A78F5C93E05C74* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();
		ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* L_0 = (ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E*)il2cpp_codegen_object_new(ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		ButtonClickedEvent__ctor_m11E8CE22A5F284BA47538B195E671ED435A7DD44(L_0, NULL);
		__this->___m_OnClick_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_OnClick_4), (void*)L_0);
		UIBehaviour__ctor_m24C66A65DDD996E779871C6655CF11B871F11337(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.TintedButton/ButtonClickedEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonClickedEvent__ctor_m11E8CE22A5F284BA47538B195E671ED435A7DD44 (ButtonClickedEvent_t39E0D4BB6D1869A943E9B1743A00764BDA99866E* __this, const RuntimeMethod* method) 
{
	{
		UnityEvent__ctor_m03D3E5121B9A6100351984D0CE3050B909CD3235(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.TintedButton/<DarkenColor>d__16::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CDarkenColorU3Ed__16__ctor_mD8802F5C9B230BAFFBCA94B51C9508FE380A0228 (U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->___U3CU3E1__state_0 = L_0;
		return;
	}
}
// System.Void Ricimi.TintedButton/<DarkenColor>d__16::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CDarkenColorU3Ed__16_System_IDisposable_Dispose_m5F0DBE07AB3AE8F1E3A961A9208CFC613E7348F6 (U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean Ricimi.TintedButton/<DarkenColor>d__16::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CDarkenColorU3Ed__16_MoveNext_mFD59999D847400C2DF9153A910DF523D8ADB8071 (U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_1;
	memset((&V_1), 0, sizeof(V_1));
	int32_t V_2 = 0;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (!L_1)
		{
			goto IL_0010;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)1)))
		{
			goto IL_0081;
		}
	}
	{
		return (bool)0;
	}

IL_0010:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// for (int i = 0; i < 20; i++)
		__this->___U3CiU3E5__2_3 = 0;
		goto IL_0098;
	}

IL_0020:
	{
		// var newColor = image.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = __this->___image_2;
		NullCheck(L_3);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4;
		L_4 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_3);
		V_1 = L_4;
		// newColor.r -= 0.01f;
		float* L_5 = (&(&V_1)->___r_0);
		float* L_6 = L_5;
		float L_7 = *((float*)L_6);
		*((float*)L_6) = (float)((float)il2cpp_codegen_subtract(L_7, (0.00999999978f)));
		// newColor.g -= 0.01f;
		float* L_8 = (&(&V_1)->___g_1);
		float* L_9 = L_8;
		float L_10 = *((float*)L_9);
		*((float*)L_9) = (float)((float)il2cpp_codegen_subtract(L_10, (0.00999999978f)));
		// newColor.b -= 0.01f;
		float* L_11 = (&(&V_1)->___b_2);
		float* L_12 = L_11;
		float L_13 = *((float*)L_12);
		*((float*)L_12) = (float)((float)il2cpp_codegen_subtract(L_13, (0.00999999978f)));
		// image.color = newColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_14 = __this->___image_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_15 = V_1;
		NullCheck(L_14);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_14, L_15);
		// yield return new WaitForSeconds(0.01f);
		WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3* L_16 = (WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3*)il2cpp_codegen_object_new(WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var);
		NullCheck(L_16);
		WaitForSeconds__ctor_m579F95BADEDBAB4B3A7E302C6EE3995926EF2EFC(L_16, (0.00999999978f), NULL);
		__this->___U3CU3E2__current_1 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_16);
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_0081:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// for (int i = 0; i < 20; i++)
		int32_t L_17 = __this->___U3CiU3E5__2_3;
		V_2 = L_17;
		int32_t L_18 = V_2;
		__this->___U3CiU3E5__2_3 = ((int32_t)il2cpp_codegen_add(L_18, 1));
	}

IL_0098:
	{
		// for (int i = 0; i < 20; i++)
		int32_t L_19 = __this->___U3CiU3E5__2_3;
		if ((((int32_t)L_19) < ((int32_t)((int32_t)20))))
		{
			goto IL_0020;
		}
	}
	{
		// }
		return (bool)0;
	}
}
// System.Object Ricimi.TintedButton/<DarkenColor>d__16::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CDarkenColorU3Ed__16_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_m37AE84C6E695B9AFB8BEB2ACA0EF353CA35AB750 (U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void Ricimi.TintedButton/<DarkenColor>d__16::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CDarkenColorU3Ed__16_System_Collections_IEnumerator_Reset_m43F480B241F3895CA58E9B51FE7A164010DAE939 (U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CDarkenColorU3Ed__16_System_Collections_IEnumerator_Reset_m43F480B241F3895CA58E9B51FE7A164010DAE939_RuntimeMethod_var)));
	}
}
// System.Object Ricimi.TintedButton/<DarkenColor>d__16::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CDarkenColorU3Ed__16_System_Collections_IEnumerator_get_Current_mB0635761963102D9BF44FE66F757766F4251D707 (U3CDarkenColorU3Ed__16_tA6E4F61709CB3B3627AD4ACC4AB2350485D0C87A* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.TintedButton/<BrightenColor>d__17::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CBrightenColorU3Ed__17__ctor_mF812D99D9D7073067A921DA7A9B4FEC06EB8D40D (U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->___U3CU3E1__state_0 = L_0;
		return;
	}
}
// System.Void Ricimi.TintedButton/<BrightenColor>d__17::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CBrightenColorU3Ed__17_System_IDisposable_Dispose_mE260CB06B69F9DE6D1CF04E6661FC81B70460669 (U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean Ricimi.TintedButton/<BrightenColor>d__17::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CBrightenColorU3Ed__17_MoveNext_mA84D9CCA31F3AC646E215FE75D146BA0058FDE22 (U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_1;
	memset((&V_1), 0, sizeof(V_1));
	int32_t V_2 = 0;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (!L_1)
		{
			goto IL_0010;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)1)))
		{
			goto IL_0081;
		}
	}
	{
		return (bool)0;
	}

IL_0010:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// for (int i = 0; i < 20; i++)
		__this->___U3CiU3E5__2_3 = 0;
		goto IL_0098;
	}

IL_0020:
	{
		// var newColor = image.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = __this->___image_2;
		NullCheck(L_3);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4;
		L_4 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_3);
		V_1 = L_4;
		// newColor.r += 0.01f;
		float* L_5 = (&(&V_1)->___r_0);
		float* L_6 = L_5;
		float L_7 = *((float*)L_6);
		*((float*)L_6) = (float)((float)il2cpp_codegen_add(L_7, (0.00999999978f)));
		// newColor.g += 0.01f;
		float* L_8 = (&(&V_1)->___g_1);
		float* L_9 = L_8;
		float L_10 = *((float*)L_9);
		*((float*)L_9) = (float)((float)il2cpp_codegen_add(L_10, (0.00999999978f)));
		// newColor.b += 0.01f;
		float* L_11 = (&(&V_1)->___b_2);
		float* L_12 = L_11;
		float L_13 = *((float*)L_12);
		*((float*)L_12) = (float)((float)il2cpp_codegen_add(L_13, (0.00999999978f)));
		// image.color = newColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_14 = __this->___image_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_15 = V_1;
		NullCheck(L_14);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_14, L_15);
		// yield return new WaitForSeconds(0.01f);
		WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3* L_16 = (WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3*)il2cpp_codegen_object_new(WaitForSeconds_tF179DF251655B8DF044952E70A60DF4B358A3DD3_il2cpp_TypeInfo_var);
		NullCheck(L_16);
		WaitForSeconds__ctor_m579F95BADEDBAB4B3A7E302C6EE3995926EF2EFC(L_16, (0.00999999978f), NULL);
		__this->___U3CU3E2__current_1 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_16);
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_0081:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// for (int i = 0; i < 20; i++)
		int32_t L_17 = __this->___U3CiU3E5__2_3;
		V_2 = L_17;
		int32_t L_18 = V_2;
		__this->___U3CiU3E5__2_3 = ((int32_t)il2cpp_codegen_add(L_18, 1));
	}

IL_0098:
	{
		// for (int i = 0; i < 20; i++)
		int32_t L_19 = __this->___U3CiU3E5__2_3;
		if ((((int32_t)L_19) < ((int32_t)((int32_t)20))))
		{
			goto IL_0020;
		}
	}
	{
		// }
		return (bool)0;
	}
}
// System.Object Ricimi.TintedButton/<BrightenColor>d__17::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CBrightenColorU3Ed__17_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mCD2A3C00BFA3CA56FD83B4F33E46414352F1D9AC (U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void Ricimi.TintedButton/<BrightenColor>d__17::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CBrightenColorU3Ed__17_System_Collections_IEnumerator_Reset_m04B6E0737535BAEF3ED1A55F292EEA88D0638499 (U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CBrightenColorU3Ed__17_System_Collections_IEnumerator_Reset_m04B6E0737535BAEF3ED1A55F292EEA88D0638499_RuntimeMethod_var)));
	}
}
// System.Object Ricimi.TintedButton/<BrightenColor>d__17::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CBrightenColorU3Ed__17_System_Collections_IEnumerator_get_Current_mAC725D90717684825C7EA344D45FFAEF8B12CB16 (U3CBrightenColorU3Ed__17_t2DD302F89087D2308CBFA14AAC112735AEEDFE6B* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.Transition::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transition_Awake_mB2721B0E6A202BDD3ECCEE05F82BC1CBD88F96B9 (Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_AddComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_m13C85FD585C0679530F8B35D0B39D965702FD0F5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF30B1954717235507FA88FE3CCF0EDAA57C6BDC5);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_canvas = new GameObject("TransitionCanvas");
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)il2cpp_codegen_object_new(GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88(L_0, _stringLiteralF30B1954717235507FA88FE3CCF0EDAA57C6BDC5, NULL);
		((Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields*)il2cpp_codegen_static_fields_for(Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var))->___m_canvas_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields*)il2cpp_codegen_static_fields_for(Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var))->___m_canvas_4), (void*)L_0);
		// var canvas = m_canvas.AddComponent<Canvas>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1 = ((Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields*)il2cpp_codegen_static_fields_for(Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var))->___m_canvas_4;
		NullCheck(L_1);
		Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* L_2;
		L_2 = GameObject_AddComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_m13C85FD585C0679530F8B35D0B39D965702FD0F5(L_1, GameObject_AddComponent_TisCanvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26_m13C85FD585C0679530F8B35D0B39D965702FD0F5_RuntimeMethod_var);
		// canvas.renderMode = RenderMode.ScreenSpaceOverlay;
		NullCheck(L_2);
		Canvas_set_renderMode_mD73E953F8A115CF469508448A00D0EDAFAF5AB47(L_2, 0, NULL);
		// DontDestroyOnLoad(m_canvas);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3 = ((Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields*)il2cpp_codegen_static_fields_for(Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var))->___m_canvas_4;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_DontDestroyOnLoad_m4B70C3AEF886C176543D1295507B6455C9DCAEA7(L_3, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.Transition::LoadLevel(System.String,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transition_LoadLevel_m91F593BEC887DF1F9C68F093CB0A021A77A7592D (String_t* ___level0, float ___duration1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_AddComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_mD73B7D6B9F588A50174DF721AF3EDEA2B35A0121_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_m064CAE44C544384024AE4043702D2BEC084DF9EC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCD444BB2FB0B21493A7D6581BF6B7AFC93A5C552);
		s_Il2CppMethodInitialized = true;
	}
	{
		// var fade = new GameObject("Transition");
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)il2cpp_codegen_object_new(GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88(L_0, _stringLiteralCD444BB2FB0B21493A7D6581BF6B7AFC93A5C552, NULL);
		// fade.AddComponent<Transition>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1 = L_0;
		NullCheck(L_1);
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_2;
		L_2 = GameObject_AddComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_mD73B7D6B9F588A50174DF721AF3EDEA2B35A0121(L_1, GameObject_AddComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_mD73B7D6B9F588A50174DF721AF3EDEA2B35A0121_RuntimeMethod_var);
		// fade.GetComponent<Transition>().StartFade(level, duration, color);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3 = L_1;
		NullCheck(L_3);
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_4;
		L_4 = GameObject_GetComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_m064CAE44C544384024AE4043702D2BEC084DF9EC(L_3, GameObject_GetComponent_TisTransition_tD3D7356191E3387D36D7B57C22E5021280E80951_m064CAE44C544384024AE4043702D2BEC084DF9EC_RuntimeMethod_var);
		String_t* L_5 = ___level0;
		float L_6 = ___duration1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_7 = ___color2;
		NullCheck(L_4);
		Transition_StartFade_mDC18A7ECE5395AFFACB3A65963FB4E01F1139745(L_4, L_5, L_6, L_7, NULL);
		// fade.transform.SetParent(m_canvas.transform, false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_8 = L_3;
		NullCheck(L_8);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_9;
		L_9 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_8, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_10 = ((Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields*)il2cpp_codegen_static_fields_for(Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var))->___m_canvas_4;
		NullCheck(L_10);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_11;
		L_11 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_10, NULL);
		NullCheck(L_9);
		Transform_SetParent_m9BDD7B7476714B2D7919B10BDC22CE75C0A0A195(L_9, L_11, (bool)0, NULL);
		// fade.transform.SetAsLastSibling();
		NullCheck(L_8);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_12;
		L_12 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_8, NULL);
		NullCheck(L_12);
		Transform_SetAsLastSibling_m848AF1A0B4C7912FE88D8CBCF92B83D57B2B917E(L_12, NULL);
		// }
		return;
	}
}
// System.Void Ricimi.Transition::StartFade(System.String,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transition_StartFade_mDC18A7ECE5395AFFACB3A65963FB4E01F1139745 (Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* __this, String_t* ___level0, float ___duration1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___fadeColor2, const RuntimeMethod* method) 
{
	{
		// StartCoroutine(RunFade(level, duration, fadeColor));
		String_t* L_0 = ___level0;
		float L_1 = ___duration1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___fadeColor2;
		RuntimeObject* L_3;
		L_3 = Transition_RunFade_mD06625DCF3018A51106284573A7DA1A3E2E88062(__this, L_0, L_1, L_2, NULL);
		Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* L_4;
		L_4 = MonoBehaviour_StartCoroutine_m4CAFF732AA28CD3BDC5363B44A863575530EC812(__this, L_3, NULL);
		// }
		return;
	}
}
// System.Collections.IEnumerator Ricimi.Transition::RunFade(System.String,System.Single,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Transition_RunFade_mD06625DCF3018A51106284573A7DA1A3E2E88062 (Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* __this, String_t* ___level0, float ___duration1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___fadeColor2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* L_0 = (U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D*)il2cpp_codegen_object_new(U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CRunFadeU3Ed__5__ctor_mCDF3EFFE6F70440D9EE3537DA54C1F522B85B739(L_0, 0, NULL);
		U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_3 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_3), (void*)__this);
		U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* L_2 = L_1;
		String_t* L_3 = ___level0;
		NullCheck(L_2);
		L_2->___level_5 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&L_2->___level_5), (void*)L_3);
		U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* L_4 = L_2;
		float L_5 = ___duration1;
		NullCheck(L_4);
		L_4->___duration_4 = L_5;
		U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* L_6 = L_4;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_7 = ___fadeColor2;
		NullCheck(L_6);
		L_6->___fadeColor_2 = L_7;
		return L_6;
	}
}
// System.Void Ricimi.Transition::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transition__ctor_m63AE6A4C9466CF450A86E4CF1125827A74780B73 (Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Ricimi.Transition/<RunFade>d__5::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeU3Ed__5__ctor_mCDF3EFFE6F70440D9EE3537DA54C1F522B85B739 (U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->___U3CU3E1__state_0 = L_0;
		return;
	}
}
// System.Void Ricimi.Transition/<RunFade>d__5::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeU3Ed__5_System_IDisposable_Dispose_m9CD238F46B4D4ADC27DC421BAC30DFAD2F8E93A3 (U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean Ricimi.Transition/<RunFade>d__5::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CRunFadeU3Ed__5_MoveNext_mA92C996A36BF5069F59EF23C21B317187F8149C4 (U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_AddComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA327C9E1CA12BC531D587E7567F2067B96E6B6A0_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* V_1 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_2 = NULL;
	Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D V_3;
	memset((&V_3), 0, sizeof(V_3));
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* V_4 = NULL;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_5;
	memset((&V_5), 0, sizeof(V_5));
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_1 = __this->___U3CU3E4__this_3;
		V_1 = L_1;
		int32_t L_2 = V_0;
		switch (L_2)
		{
			case 0:
			{
				goto IL_002a;
			}
			case 1:
			{
				goto IL_01d1;
			}
			case 2:
			{
				goto IL_020f;
			}
			case 3:
			{
				goto IL_0280;
			}
			case 4:
			{
				goto IL_02be;
			}
		}
	}
	{
		return (bool)0;
	}

IL_002a:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// var bgTex = new Texture2D(1, 1);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_3 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796(L_3, 1, 1, NULL);
		V_2 = L_3;
		// bgTex.SetPixel(0, 0, fadeColor);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_4 = V_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_5 = __this->___fadeColor_2;
		NullCheck(L_4);
		Texture2D_SetPixel_m2CCFC5F729135D59DC4A697C2605A3FC5C8574DB(L_4, 0, 0, L_5, NULL);
		// bgTex.Apply();
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_6 = V_2;
		NullCheck(L_6);
		Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_6, NULL);
		// m_overlay = new GameObject();
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_7 = V_1;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_8 = (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)il2cpp_codegen_object_new(GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		GameObject__ctor_m7D0340DE160786E6EFA8DABD39EC3B694DA30AAD(L_8, NULL);
		NullCheck(L_7);
		L_7->___m_overlay_5 = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&L_7->___m_overlay_5), (void*)L_8);
		// var image = m_overlay.AddComponent<Image>();
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_9 = V_1;
		NullCheck(L_9);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_10 = L_9->___m_overlay_5;
		NullCheck(L_10);
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_11;
		L_11 = GameObject_AddComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA327C9E1CA12BC531D587E7567F2067B96E6B6A0(L_10, GameObject_AddComponent_TisImage_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_mA327C9E1CA12BC531D587E7567F2067B96E6B6A0_RuntimeMethod_var);
		__this->___U3CimageU3E5__2_6 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CimageU3E5__2_6), (void*)L_11);
		// var rect = new Rect(0, 0, bgTex.width, bgTex.height);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_12 = V_2;
		NullCheck(L_12);
		int32_t L_13;
		L_13 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_12);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_14 = V_2;
		NullCheck(L_14);
		int32_t L_15;
		L_15 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_14);
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&V_3), (0.0f), (0.0f), ((float)L_13), ((float)L_15), NULL);
		// var sprite = Sprite.Create(bgTex, rect, new Vector2(0.5f, 0.5f), 1);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_16 = V_2;
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_17 = V_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_18;
		memset((&L_18), 0, sizeof(L_18));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_18), (0.5f), (0.5f), /*hidden argument*/NULL);
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_19;
		L_19 = Sprite_Create_m95F90AD74982187C087F4FA00947045A033D0BA1(L_16, L_17, L_18, (1.0f), NULL);
		V_4 = L_19;
		// image.material.mainTexture = bgTex;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_20 = __this->___U3CimageU3E5__2_6;
		NullCheck(L_20);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_21;
		L_21 = VirtualFuncInvoker0< Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* >::Invoke(32 /* UnityEngine.Material UnityEngine.UI.Graphic::get_material() */, L_20);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_22 = V_2;
		NullCheck(L_21);
		Material_set_mainTexture_m389E048BA9C81B603EBF36BD792212B296317AC0(L_21, L_22, NULL);
		// image.sprite = sprite;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_23 = __this->___U3CimageU3E5__2_6;
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_24 = V_4;
		NullCheck(L_23);
		Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE(L_23, L_24, NULL);
		// var newColor = image.color;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_25 = __this->___U3CimageU3E5__2_6;
		NullCheck(L_25);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_26;
		L_26 = VirtualFuncInvoker0< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(22 /* UnityEngine.Color UnityEngine.UI.Graphic::get_color() */, L_25);
		V_5 = L_26;
		// image.color = newColor;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_27 = __this->___U3CimageU3E5__2_6;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_28 = V_5;
		NullCheck(L_27);
		VirtualActionInvoker1< Color_tD001788D726C3A7F1379BEED0260B9591F440C1F >::Invoke(23 /* System.Void UnityEngine.UI.Graphic::set_color(UnityEngine.Color) */, L_27, L_28);
		// image.canvasRenderer.SetAlpha(0.0f);
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_29 = __this->___U3CimageU3E5__2_6;
		NullCheck(L_29);
		CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* L_30;
		L_30 = Graphic_get_canvasRenderer_m62AB727277A28728264860232642DA6EC20DEAB1(L_29, NULL);
		NullCheck(L_30);
		CanvasRenderer_SetAlpha_m97E196A1CC718DE16300954D25B4125952D7632C(L_30, (0.0f), NULL);
		// m_overlay.transform.localScale = new Vector3(1, 1, 1);
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_31 = V_1;
		NullCheck(L_31);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_32 = L_31->___m_overlay_5;
		NullCheck(L_32);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_33;
		L_33 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_32, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34;
		memset((&L_34), 0, sizeof(L_34));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_34), (1.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		NullCheck(L_33);
		Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633(L_33, L_34, NULL);
		// m_overlay.GetComponent<RectTransform>().sizeDelta = m_canvas.GetComponent<RectTransform>().sizeDelta;
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_35 = V_1;
		NullCheck(L_35);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_36 = L_35->___m_overlay_5;
		NullCheck(L_36);
		RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* L_37;
		L_37 = GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4(L_36, GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4_RuntimeMethod_var);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_38 = ((Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields*)il2cpp_codegen_static_fields_for(Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var))->___m_canvas_4;
		NullCheck(L_38);
		RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* L_39;
		L_39 = GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4(L_38, GameObject_GetComponent_TisRectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5_m1592DCB5AA07291F73A76006F0913A64DFB8A9C4_RuntimeMethod_var);
		NullCheck(L_39);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_40;
		L_40 = RectTransform_get_sizeDelta_m822A8493F2035677384F1540A2E9E5ACE63010BB(L_39, NULL);
		NullCheck(L_37);
		RectTransform_set_sizeDelta_mC9A980EA6036E6725EF24CEDF3EE80A9B2B50EE5(L_37, L_40, NULL);
		// m_overlay.transform.SetParent(m_canvas.transform, false);
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_41 = V_1;
		NullCheck(L_41);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_42 = L_41->___m_overlay_5;
		NullCheck(L_42);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_43;
		L_43 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_42, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_44 = ((Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields*)il2cpp_codegen_static_fields_for(Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var))->___m_canvas_4;
		NullCheck(L_44);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_45;
		L_45 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_44, NULL);
		NullCheck(L_43);
		Transform_SetParent_m9BDD7B7476714B2D7919B10BDC22CE75C0A0A195(L_43, L_45, (bool)0, NULL);
		// m_overlay.transform.SetAsFirstSibling();
		Transition_tD3D7356191E3387D36D7B57C22E5021280E80951* L_46 = V_1;
		NullCheck(L_46);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_47 = L_46->___m_overlay_5;
		NullCheck(L_47);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_48;
		L_48 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_47, NULL);
		NullCheck(L_48);
		Transform_SetAsFirstSibling_mBE0D0E76099F829466DC2FBD71ACFCF3C8EC03BD(L_48, NULL);
		// var time = 0.0f;
		__this->___U3CtimeU3E5__3_7 = (0.0f);
		// var halfDuration = duration / 2.0f;
		float L_49 = __this->___duration_4;
		__this->___U3ChalfDurationU3E5__4_8 = ((float)(L_49/(2.0f)));
		goto IL_01d8;
	}

IL_017f:
	{
		// time += Time.deltaTime;
		float L_50 = __this->___U3CtimeU3E5__3_7;
		float L_51;
		L_51 = Time_get_deltaTime_mC3195000401F0FD167DD2F948FD2BC58330D0865(NULL);
		__this->___U3CtimeU3E5__3_7 = ((float)il2cpp_codegen_add(L_50, L_51));
		// image.canvasRenderer.SetAlpha(Mathf.InverseLerp(0, 1, time / halfDuration));
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_52 = __this->___U3CimageU3E5__2_6;
		NullCheck(L_52);
		CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* L_53;
		L_53 = Graphic_get_canvasRenderer_m62AB727277A28728264860232642DA6EC20DEAB1(L_52, NULL);
		float L_54 = __this->___U3CtimeU3E5__3_7;
		float L_55 = __this->___U3ChalfDurationU3E5__4_8;
		float L_56;
		L_56 = Mathf_InverseLerp_mBD7EC6A7173CE082226077E1557D5BC2D2AE0D9D_inline((0.0f), (1.0f), ((float)(L_54/L_55)), NULL);
		NullCheck(L_53);
		CanvasRenderer_SetAlpha_m97E196A1CC718DE16300954D25B4125952D7632C(L_53, L_56, NULL);
		// yield return new WaitForEndOfFrame();
		WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663* L_57 = (WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663*)il2cpp_codegen_object_new(WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		NullCheck(L_57);
		WaitForEndOfFrame__ctor_m4AF7E576C01E6B04443BB898B1AE5D645F7D45AB(L_57, NULL);
		__this->___U3CU3E2__current_1 = L_57;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_57);
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_01d1:
	{
		__this->___U3CU3E1__state_0 = (-1);
	}

IL_01d8:
	{
		// while (time < halfDuration)
		float L_58 = __this->___U3CtimeU3E5__3_7;
		float L_59 = __this->___U3ChalfDurationU3E5__4_8;
		if ((((float)L_58) < ((float)L_59)))
		{
			goto IL_017f;
		}
	}
	{
		// image.canvasRenderer.SetAlpha(1.0f);
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_60 = __this->___U3CimageU3E5__2_6;
		NullCheck(L_60);
		CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* L_61;
		L_61 = Graphic_get_canvasRenderer_m62AB727277A28728264860232642DA6EC20DEAB1(L_60, NULL);
		NullCheck(L_61);
		CanvasRenderer_SetAlpha_m97E196A1CC718DE16300954D25B4125952D7632C(L_61, (1.0f), NULL);
		// yield return new WaitForEndOfFrame();
		WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663* L_62 = (WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663*)il2cpp_codegen_object_new(WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		NullCheck(L_62);
		WaitForEndOfFrame__ctor_m4AF7E576C01E6B04443BB898B1AE5D645F7D45AB(L_62, NULL);
		__this->___U3CU3E2__current_1 = L_62;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_62);
		__this->___U3CU3E1__state_0 = 2;
		return (bool)1;
	}

IL_020f:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// SceneManager.LoadScene(level);
		String_t* L_63 = __this->___level_5;
		il2cpp_codegen_runtime_class_init_inline(SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		SceneManager_LoadScene_mBB3DBC1601A21F8F4E8A5D68FED30EA9412F218E(L_63, NULL);
		// time = 0.0f;
		__this->___U3CtimeU3E5__3_7 = (0.0f);
		goto IL_0287;
	}

IL_022e:
	{
		// time += Time.deltaTime;
		float L_64 = __this->___U3CtimeU3E5__3_7;
		float L_65;
		L_65 = Time_get_deltaTime_mC3195000401F0FD167DD2F948FD2BC58330D0865(NULL);
		__this->___U3CtimeU3E5__3_7 = ((float)il2cpp_codegen_add(L_64, L_65));
		// image.canvasRenderer.SetAlpha(Mathf.InverseLerp(1, 0, time / halfDuration));
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_66 = __this->___U3CimageU3E5__2_6;
		NullCheck(L_66);
		CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* L_67;
		L_67 = Graphic_get_canvasRenderer_m62AB727277A28728264860232642DA6EC20DEAB1(L_66, NULL);
		float L_68 = __this->___U3CtimeU3E5__3_7;
		float L_69 = __this->___U3ChalfDurationU3E5__4_8;
		float L_70;
		L_70 = Mathf_InverseLerp_mBD7EC6A7173CE082226077E1557D5BC2D2AE0D9D_inline((1.0f), (0.0f), ((float)(L_68/L_69)), NULL);
		NullCheck(L_67);
		CanvasRenderer_SetAlpha_m97E196A1CC718DE16300954D25B4125952D7632C(L_67, L_70, NULL);
		// yield return new WaitForEndOfFrame();
		WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663* L_71 = (WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663*)il2cpp_codegen_object_new(WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		NullCheck(L_71);
		WaitForEndOfFrame__ctor_m4AF7E576C01E6B04443BB898B1AE5D645F7D45AB(L_71, NULL);
		__this->___U3CU3E2__current_1 = L_71;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_71);
		__this->___U3CU3E1__state_0 = 3;
		return (bool)1;
	}

IL_0280:
	{
		__this->___U3CU3E1__state_0 = (-1);
	}

IL_0287:
	{
		// while (time < halfDuration)
		float L_72 = __this->___U3CtimeU3E5__3_7;
		float L_73 = __this->___U3ChalfDurationU3E5__4_8;
		if ((((float)L_72) < ((float)L_73)))
		{
			goto IL_022e;
		}
	}
	{
		// image.canvasRenderer.SetAlpha(0.0f);
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_74 = __this->___U3CimageU3E5__2_6;
		NullCheck(L_74);
		CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* L_75;
		L_75 = Graphic_get_canvasRenderer_m62AB727277A28728264860232642DA6EC20DEAB1(L_74, NULL);
		NullCheck(L_75);
		CanvasRenderer_SetAlpha_m97E196A1CC718DE16300954D25B4125952D7632C(L_75, (0.0f), NULL);
		// yield return new WaitForEndOfFrame();
		WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663* L_76 = (WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663*)il2cpp_codegen_object_new(WaitForEndOfFrame_tE38D80923E3F8380069B423968C25ABE50A46663_il2cpp_TypeInfo_var);
		NullCheck(L_76);
		WaitForEndOfFrame__ctor_m4AF7E576C01E6B04443BB898B1AE5D645F7D45AB(L_76, NULL);
		__this->___U3CU3E2__current_1 = L_76;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CU3E2__current_1), (void*)L_76);
		__this->___U3CU3E1__state_0 = 4;
		return (bool)1;
	}

IL_02be:
	{
		__this->___U3CU3E1__state_0 = (-1);
		// Destroy(m_canvas);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_77 = ((Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_StaticFields*)il2cpp_codegen_static_fields_for(Transition_tD3D7356191E3387D36D7B57C22E5021280E80951_il2cpp_TypeInfo_var))->___m_canvas_4;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB(L_77, NULL);
		// }
		return (bool)0;
	}
}
// System.Object Ricimi.Transition/<RunFade>d__5::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CRunFadeU3Ed__5_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mBC3EF759F4448C8386B909D0D851AFA0DE3D4E69 (U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void Ricimi.Transition/<RunFade>d__5::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRunFadeU3Ed__5_System_Collections_IEnumerator_Reset_m6B71FF6A0F04C12F03B9B4F0CC01590E8922A422 (U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CRunFadeU3Ed__5_System_Collections_IEnumerator_Reset_m6B71FF6A0F04C12F03B9B4F0CC01590E8922A422_RuntimeMethod_var)));
	}
}
// System.Object Ricimi.Transition/<RunFade>d__5::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CRunFadeU3Ed__5_System_Collections_IEnumerator_get_Current_m3575E3CB4DA56052A5B370000CE630E8F4EC1BB7 (U3CRunFadeU3Ed__5_t663A4CA28476058886A0790F1C41165ECA94FE7D* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___x0, float ___y1, const RuntimeMethod* method) 
{
	{
		float L_0 = ___x0;
		__this->___x_0 = L_0;
		float L_1 = ___y1;
		__this->___y_1 = L_1;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Subtraction_m44475FCDAD2DA2F98D78A6625EC2DCDFE8803837_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___a0, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___b1, const RuntimeMethod* method) 
{
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___a0;
		float L_1 = L_0.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_2 = ___b1;
		float L_3 = L_2.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4 = ___a0;
		float L_5 = L_4.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_6 = ___b1;
		float L_7 = L_6.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_8), ((float)il2cpp_codegen_subtract(L_1, L_3)), ((float)il2cpp_codegen_subtract(L_5, L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0023;
	}

IL_0023:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_9 = V_0;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t PointerEventData_get_button_mA8CBDAF2E16927E6952BC60040D56630BCC95B0B_inline (PointerEventData_t9670F3C7D823CCB738A1604C72A1EB90292396FB* __this, const RuntimeMethod* method) 
{
	{
		// public InputButton button { get; set; }
		int32_t L_0 = __this->___U3CbuttonU3Ek__BackingField_23;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Lerp_m47EF2FFB7647BD0A1FDC26DC03E28B19812139B5_inline (float ___a0, float ___b1, float ___t2, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		float L_0 = ___a0;
		float L_1 = ___b1;
		float L_2 = ___a0;
		float L_3 = ___t2;
		float L_4;
		L_4 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(L_3, NULL);
		V_0 = ((float)il2cpp_codegen_add(L_0, ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(L_1, L_2)), L_4))));
		goto IL_0010;
	}

IL_0010:
	{
		float L_5 = V_0;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___zeroVector_5;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method) 
{
	{
		float L_0 = ___x0;
		__this->___x_2 = L_0;
		float L_1 = ___y1;
		__this->___y_3 = L_1;
		float L_2 = ___z2;
		__this->___z_4 = L_2;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___r0, float ___g1, float ___b2, float ___a3, const RuntimeMethod* method) 
{
	{
		float L_0 = ___r0;
		__this->___r_0 = L_0;
		float L_1 = ___g1;
		__this->___g_1 = L_1;
		float L_2 = ___b2;
		__this->___b_2 = L_2;
		float L_3 = ___a3;
		__this->___a_3 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_black_mB50217951591A045844C61E7FF31EEE3FEF16737_inline (const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		memset((&L_0), 0, sizeof(L_0));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_0), (0.0f), (0.0f), (0.0f), (1.0f), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_001d;
	}

IL_001d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_InverseLerp_mBD7EC6A7173CE082226077E1557D5BC2D2AE0D9D_inline (float ___a0, float ___b1, float ___value2, const RuntimeMethod* method) 
{
	bool V_0 = false;
	float V_1 = 0.0f;
	{
		float L_0 = ___a0;
		float L_1 = ___b1;
		V_0 = (bool)((((int32_t)((((float)L_0) == ((float)L_1))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001b;
		}
	}
	{
		float L_3 = ___value2;
		float L_4 = ___a0;
		float L_5 = ___b1;
		float L_6 = ___a0;
		float L_7;
		L_7 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(((float)(((float)il2cpp_codegen_subtract(L_3, L_4))/((float)il2cpp_codegen_subtract(L_5, L_6)))), NULL);
		V_1 = L_7;
		goto IL_0023;
	}

IL_001b:
	{
		V_1 = (0.0f);
		goto IL_0023;
	}

IL_0023:
	{
		float L_8 = V_1;
		return L_8;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline (float ___value0, const RuntimeMethod* method) 
{
	bool V_0 = false;
	float V_1 = 0.0f;
	bool V_2 = false;
	{
		float L_0 = ___value0;
		V_0 = (bool)((((float)L_0) < ((float)(0.0f)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		V_1 = (0.0f);
		goto IL_002d;
	}

IL_0015:
	{
		float L_2 = ___value0;
		V_2 = (bool)((((float)L_2) > ((float)(1.0f)))? 1 : 0);
		bool L_3 = V_2;
		if (!L_3)
		{
			goto IL_0029;
		}
	}
	{
		V_1 = (1.0f);
		goto IL_002d;
	}

IL_0029:
	{
		float L_4 = ___value0;
		V_1 = L_4;
		goto IL_002d;
	}

IL_002d:
	{
		float L_5 = V_1;
		return L_5;
	}
}
