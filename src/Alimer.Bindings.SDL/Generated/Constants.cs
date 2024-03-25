// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace SDL;

public static partial class SDL
{
	public const uint SDL_PEN_FLAG_DOWN_BIT_INDEX = 13;
	public const uint SDL_PEN_FLAG_INK_BIT_INDEX = 14;
	public const uint SDL_PEN_FLAG_ERASER_BIT_INDEX = 15;
	public const uint SDL_PEN_FLAG_AXIS_BIT_OFFSET = 16;
	public const uint SDL_PEN_TIP_INK = SDL_PEN_FLAG_INK_BIT_INDEX;
	public const uint SDL_PEN_TIP_ERASER = SDL_PEN_FLAG_ERASER_BIT_INDEX;
	public const uint SDL_CACHELINE_SIZE = 128;
	public static ReadOnlySpan<byte> SDL_PROP_IOSTREAM_WINDOWS_HANDLE_POINTER => "SDL.iostream.windows.handle"u8;
	public static ReadOnlySpan<byte> SDL_PROP_IOSTREAM_STDIO_FILE_POINTER => "SDL.iostream.stdio.file"u8;
	public static ReadOnlySpan<byte> SDL_PROP_IOSTREAM_ANDROID_AASSET_POINTER => "SDL.iostream.android.aasset"u8;
	public static ReadOnlySpan<byte> SDL_PROP_IOSTREAM_DYNAMIC_MEMORY_POINTER => "SDL.iostream.dynamic.memory"u8;
	public static ReadOnlySpan<byte> SDL_PROP_IOSTREAM_DYNAMIC_CHUNKSIZE_NUMBER => "SDL.iostream.dynamic.chunksize"u8;
	public const uint SDL_IO_SEEK_SET = 0;
	public const uint SDL_IO_SEEK_CUR = 1;
	public const uint SDL_IO_SEEK_END = 2;
	public const int SDLK_SCANCODE_MASK = 1<<30;
	public const int SDL_JOYSTICK_AXIS_MAX = 32767;
	public const int SDL_JOYSTICK_AXIS_MIN = -32768;
	public const float SDL_IPHONE_MAX_GFORCE = 5.0f;
	public const uint SDL_VIRTUAL_JOYSTICK_DESC_VERSION = 1;
	public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN => "SDL.joystick.cap.mono_led"u8;
	public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN => "SDL.joystick.cap.rgb_led"u8;
	public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN => "SDL.joystick.cap.player_led"u8;
	public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN => "SDL.joystick.cap.rumble"u8;
	public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN => "SDL.joystick.cap.trigger_rumble"u8;
	public const uint SDL_HAT_CENTERED = 0x00;
	public const uint SDL_HAT_UP = 0x01;
	public const uint SDL_HAT_RIGHT = 0x02;
	public const uint SDL_HAT_DOWN = 0x04;
	public const uint SDL_HAT_LEFT = 0x08;
	public const uint SDL_HAT_RIGHTUP = SDL_HAT_RIGHT|SDL_HAT_UP;
	public const uint SDL_HAT_RIGHTDOWN = SDL_HAT_RIGHT|SDL_HAT_DOWN;
	public const uint SDL_HAT_LEFTUP = SDL_HAT_LEFT|SDL_HAT_UP;
	public const uint SDL_HAT_LEFTDOWN = SDL_HAT_LEFT|SDL_HAT_DOWN;
	public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN => SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN;
	public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN => SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN;
	public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN => SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN;
	public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN => SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN;
	public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN => SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN;
	public const uint SDL_BUTTON_LEFT = 1;
	public const uint SDL_BUTTON_MIDDLE = 2;
	public const uint SDL_BUTTON_RIGHT = 3;
	public const uint SDL_BUTTON_X1 = 4;
	public const uint SDL_BUTTON_X2 = 5;
	public const uint SDL_MS_PER_SECOND = 1000;
	public const uint SDL_US_PER_SECOND = 1000000;
	public static ulong SDL_NS_PER_SECOND = 1000000000L;
	public const uint SDL_NS_PER_MS = 1000000;
	public const uint SDL_NS_PER_US = 1000;
	public const uint SDL_MAX_LOG_MESSAGE = 4096;
	public const float SDL_STANDARD_GRAVITY = 9.80665f;
	public static ReadOnlySpan<byte> SDL_PROP_GLOBAL_VIDEO_WAYLAND_WL_DISPLAY_POINTER => "SDL.video.wayland.wl_display"u8;
	public const uint SDL_WINDOW_FULLSCREEN = 0x00000001U;
	public const uint SDL_WINDOW_OPENGL = 0x00000002U;
	public const uint SDL_WINDOW_OCCLUDED = 0x00000004U;
	public const uint SDL_WINDOW_HIDDEN = 0x00000008U;
	public const uint SDL_WINDOW_BORDERLESS = 0x00000010U;
	public const uint SDL_WINDOW_RESIZABLE = 0x00000020U;
	public const uint SDL_WINDOW_MINIMIZED = 0x00000040U;
	public const uint SDL_WINDOW_MAXIMIZED = 0x00000080U;
	public const uint SDL_WINDOW_MOUSE_GRABBED = 0x00000100U;
	public const uint SDL_WINDOW_INPUT_FOCUS = 0x00000200U;
	public const uint SDL_WINDOW_MOUSE_FOCUS = 0x00000400U;
	public const uint SDL_WINDOW_EXTERNAL = 0x00000800U;
	public const uint SDL_WINDOW_HIGH_PIXEL_DENSITY = 0x00002000U;
	public const uint SDL_WINDOW_MOUSE_CAPTURE = 0x00004000U;
	public const uint SDL_WINDOW_ALWAYS_ON_TOP = 0x00008000U;
	public const uint SDL_WINDOW_UTILITY = 0x00020000U;
	public const uint SDL_WINDOW_TOOLTIP = 0x00040000U;
	public const uint SDL_WINDOW_POPUP_MENU = 0x00080000U;
	public const uint SDL_WINDOW_KEYBOARD_GRABBED = 0x00100000U;
	public const uint SDL_WINDOW_VULKAN = 0x10000000U;
	public const uint SDL_WINDOW_METAL = 0x20000000U;
	public const uint SDL_WINDOW_TRANSPARENT = 0x40000000U;
	public const uint SDL_WINDOW_NOT_FOCUSABLE = 0x80000000U;
	public static ReadOnlySpan<byte> SDL_PROP_DISPLAY_HDR_ENABLED_BOOLEAN => "SDL.display.HDR_enabled"u8;
	public static ReadOnlySpan<byte> SDL_PROP_DISPLAY_SDR_WHITE_POINT_FLOAT => "SDL.display.SDR_white_point"u8;
	public static ReadOnlySpan<byte> SDL_PROP_DISPLAY_HDR_HEADROOM_FLOAT => "SDL.display.HDR_headroom"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_ALWAYS_ON_TOP_BOOLEAN => "always_on_top"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_BORDERLESS_BOOLEAN => "borderless"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_FOCUSABLE_BOOLEAN => "focusable"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_EXTERNAL_GRAPHICS_CONTEXT_BOOLEAN => "external_graphics_context"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_FULLSCREEN_BOOLEAN => "fullscreen"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_HEIGHT_NUMBER => "height"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_HIDDEN_BOOLEAN => "hidden"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_HIGH_PIXEL_DENSITY_BOOLEAN => "high_pixel_density"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MAXIMIZED_BOOLEAN => "maximized"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MENU_BOOLEAN => "menu"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_METAL_BOOLEAN => "metal"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MINIMIZED_BOOLEAN => "minimized"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MOUSE_GRABBED_BOOLEAN => "mouse_grabbed"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_OPENGL_BOOLEAN => "opengl"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_PARENT_POINTER => "parent"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_RESIZABLE_BOOLEAN => "resizable"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_TITLE_STRING => "title"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_TRANSPARENT_BOOLEAN => "transparent"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_TOOLTIP_BOOLEAN => "tooltip"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_UTILITY_BOOLEAN => "utility"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_VULKAN_BOOLEAN => "vulkan"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WIDTH_NUMBER => "width"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_X_NUMBER => "x"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_Y_NUMBER => "y"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER => "cocoa.window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER => "cocoa.view"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WAYLAND_SCALE_TO_DISPLAY_BOOLEAN => "wayland.scale_to_display"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN => "wayland.surface_role_custom"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN => "wayland.create_egl_window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER => "wayland.wl_surface"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER => "win32.hwnd"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER => "win32.pixel_format_hwnd"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER => "x11.window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_SHAPE_POINTER => "SDL.window.shape"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_ANDROID_WINDOW_POINTER => "SDL.window.android.window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_ANDROID_SURFACE_POINTER => "SDL.window.android.surface"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_UIKIT_WINDOW_POINTER => "SDL.window.uikit.window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER => "SDL.window.uikit.metal_view_tag"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_KMSDRM_DEVICE_INDEX_NUMBER => "SDL.window.kmsdrm.dev_index"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_KMSDRM_DRM_FD_NUMBER => "SDL.window.kmsdrm.drm_fd"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_KMSDRM_GBM_DEVICE_POINTER => "SDL.window.kmsdrm.gbm_dev"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_COCOA_WINDOW_POINTER => "SDL.window.cocoa.window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_COCOA_METAL_VIEW_TAG_NUMBER => "SDL.window.cocoa.metal_view_tag"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_VIVANTE_DISPLAY_POINTER => "SDL.window.vivante.display"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_VIVANTE_WINDOW_POINTER => "SDL.window.vivante.window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_VIVANTE_SURFACE_POINTER => "SDL.window.vivante.surface"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WINRT_WINDOW_POINTER => "SDL.window.winrt.window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WIN32_HWND_POINTER => "SDL.window.win32.hwnd"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WIN32_HDC_POINTER => "SDL.window.win32.hdc"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WIN32_INSTANCE_POINTER => "SDL.window.win32.instance"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_DISPLAY_POINTER => "SDL.window.wayland.display"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_SURFACE_POINTER => "SDL.window.wayland.surface"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_EGL_WINDOW_POINTER => "SDL.window.wayland.egl_window"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_SURFACE_POINTER => "SDL.window.wayland.xdg_surface"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER => "SDL.window.wayland.xdg_toplevel"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING => "SDL.window.wayland.xdg_toplevel_export_handle"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_POPUP_POINTER => "SDL.window.wayland.xdg_popup"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_POSITIONER_POINTER => "SDL.window.wayland.xdg_positioner"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_X11_DISPLAY_POINTER => "SDL.window.x11.display"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_X11_SCREEN_NUMBER => "SDL.window.x11.screen"u8;
	public static ReadOnlySpan<byte> SDL_PROP_WINDOW_X11_WINDOW_NUMBER => "SDL.window.x11.window"u8;
	public const ushort SDL_AUDIO_MASK_BITSIZE = 0xFF;
	public const ushort SDL_AUDIO_MASK_FLOAT = 1<<8;
	public const ushort SDL_AUDIO_MASK_BIG_ENDIAN = 1<<12;
	public const ushort SDL_AUDIO_MASK_SIGNED = 1<<15;
	public const uint SDL_AUDIO_U8 = 0x0008;
	public const ushort SDL_AUDIO_S8 = 0x8008;
	public const ushort SDL_AUDIO_S16LE = 0x8010;
	public const ushort SDL_AUDIO_S16BE = 0x9010;
	public const ushort SDL_AUDIO_S32LE = 0x8020;
	public const ushort SDL_AUDIO_S32BE = 0x9020;
	public const ushort SDL_AUDIO_F32LE = 0x8120;
	public const ushort SDL_AUDIO_F32BE = 0x9120;
	public const ushort SDL_AUDIO_S16 = SDL_AUDIO_S16LE;
	public const ushort SDL_AUDIO_S32 = SDL_AUDIO_S32LE;
	public const ushort SDL_AUDIO_F32 = SDL_AUDIO_F32LE;
	public static readonly SDL_AudioDeviceID SDL_AUDIO_DEVICE_DEFAULT_OUTPUT = (SDL_AudioDeviceID)0xFFFFFFFF;
	public static readonly SDL_AudioDeviceID SDL_AUDIO_DEVICE_DEFAULT_CAPTURE = (SDL_AudioDeviceID)0xFFFFFFFE;
	public const int SDL_MIX_MAXVOLUME = 128;
	public const uint SDL_RELEASED = 0;
	public const uint SDL_PRESSED = 1;
	public const int SDL_TEXTEDITINGEVENT_TEXT_SIZE = 64;
	public const int SDL_TEXTINPUTEVENT_TEXT_SIZE = 64;
	public const uint SDL_DROPEVENT_DATA_SIZE = 64;
	public static ReadOnlySpan<byte> SDL_HINT_ALLOW_ALT_TAB_WHILE_GRABBED => "SDL_ALOW_ALT_TAB_WHILE_GRABBED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_ANDROID_ALLOW_RECREATE_ACTIVITY => "SDL_ANDROID_ALOW_RECREATE_ACTIVITY"u8;
	public static ReadOnlySpan<byte> SDL_HINT_ANDROID_BLOCK_ON_PAUSE => "SDL_ANDROID_BLOCK_ON_PAUSE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO => "SDL_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO"u8;
	public static ReadOnlySpan<byte> SDL_HINT_ANDROID_TRAP_BACK_BUTTON => "SDL_ANDROID_TRAP_BACK_BUTTON"u8;
	public static ReadOnlySpan<byte> SDL_HINT_APP_ID => "SDL_APP_ID"u8;
	public static ReadOnlySpan<byte> SDL_HINT_APP_NAME => "SDL_APP_NAME"u8;
	public static ReadOnlySpan<byte> SDL_HINT_APPLE_TV_CONTROLLER_UI_EVENTS => "SDL_APPLE_TV_CONTROLER_UI_EVENTS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_APPLE_TV_REMOTE_ALLOW_ROTATION => "SDL_APPLE_TV_REMOTE_ALOW_ROTATION"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUDIO_CATEGORY => "SDL_AUDIO_CATEGORY"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUDIO_DEVICE_APP_NAME => "SDL_AUDIO_DEVICE_APP_NAME"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUDIO_DEVICE_SAMPLE_FRAMES => "SDL_AUDIO_DEVICE_SAMPLE_FRAMES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUDIO_DEVICE_STREAM_NAME => "SDL_AUDIO_DEVICE_STREAM_NAME"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUDIO_DEVICE_STREAM_ROLE => "SDL_AUDIO_DEVICE_STREAM_ROLE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUDIO_DRIVER => "SDL_AUDIO_DRIVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUDIO_INCLUDE_MONITORS => "SDL_AUDIO_INCLUDE_MONITORS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUTO_UPDATE_JOYSTICKS => "SDL_AUTO_UPDATE_JOYSTICKS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_AUTO_UPDATE_SENSORS => "SDL_AUTO_UPDATE_SENSORS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_BMP_SAVE_LEGACY_FORMAT => "SDL_BMP_SAVE_LEGACY_FORMAT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_CAMERA_DRIVER => "SDL_CAMERA_DRIVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_CPU_FEATURE_MASK => "SDL_CPU_FEATURE_MASK"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_DIRECTINPUT => "SDL_JOYSTICK_DIRECTINPUT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_DISPLAY_USABLE_BOUNDS => "SDL_DISPLAY_USABLE_BOUNDS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_EMSCRIPTEN_ASYNCIFY => "SDL_EMSCRIPTEN_ASYNCIFY"u8;
	public static ReadOnlySpan<byte> SDL_HINT_EMSCRIPTEN_CANVAS_SELECTOR => "SDL_EMSCRIPTEN_CANVAS_SELECTOR"u8;
	public static ReadOnlySpan<byte> SDL_HINT_EMSCRIPTEN_KEYBOARD_ELEMENT => "SDL_EMSCRIPTEN_KEYBOARD_ELEMENT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_ENABLE_SCREEN_KEYBOARD => "SDL_ENABLE_SCREEN_KEYBOARD"u8;
	public static ReadOnlySpan<byte> SDL_HINT_EVENT_LOGGING => "SDL_EVENT_LOGGING"u8;
	public static ReadOnlySpan<byte> SDL_HINT_FORCE_RAISEWINDOW => "SDL_HINT_FORCE_RAISEWINDOW"u8;
	public static ReadOnlySpan<byte> SDL_HINT_FRAMEBUFFER_ACCELERATION => "SDL_FRAMEBUFFER_ACCELERATION"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLERCONFIG => "SDL_GAMECONTROLERCONFIG"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLERCONFIG_FILE => "SDL_GAMECONTROLERCONFIG_FILE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLERTYPE => "SDL_GAMECONTROLERTYPE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES => "SDL_GAMECONTROLER_IGNORE_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT => "SDL_GAMECONTROLER_IGNORE_DEVICES_EXCEPT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLER_SENSOR_FUSION => "SDL_GAMECONTROLER_SENSOR_FUSION"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GDK_TEXTINPUT_DEFAULT_TEXT => "SDL_GDK_TEXTINPUT_DEFAULT_TEXT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GDK_TEXTINPUT_DESCRIPTION => "SDL_GDK_TEXTINPUT_DESCRIPTION"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GDK_TEXTINPUT_MAX_LENGTH => "SDL_GDK_TEXTINPUT_MAX_LENGTH"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GDK_TEXTINPUT_SCOPE => "SDL_GDK_TEXTINPUT_SCOPE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_GDK_TEXTINPUT_TITLE => "SDL_GDK_TEXTINPUT_TITLE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_HIDAPI_ENUMERATE_ONLY_CONTROLLERS => "SDL_HIDAPI_ENUMERATE_ONLY_CONTROLERS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_HIDAPI_IGNORE_DEVICES => "SDL_HIDAPI_IGNORE_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_IME_INTERNAL_EDITING => "SDL_IME_INTERNAL_EDITING"u8;
	public static ReadOnlySpan<byte> SDL_HINT_IME_SHOW_UI => "SDL_IME_SHOW_UI"u8;
	public static ReadOnlySpan<byte> SDL_HINT_IOS_HIDE_HOME_INDICATOR => "SDL_IOS_HIDE_HOME_INDICATOR"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_ALLOW_BACKGROUND_EVENTS => "SDL_JOYSTICK_ALOW_BACKGROUND_EVENTS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_ARCADESTICK_DEVICES => "SDL_JOYSTICK_ARCADESTICK_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_ARCADESTICK_DEVICES_EXCLUDED => "SDL_JOYSTICK_ARCADESTICK_DEVICES_EXCLUDED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_BLACKLIST_DEVICES => "SDL_JOYSTICK_BLACKLIST_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_BLACKLIST_DEVICES_EXCLUDED => "SDL_JOYSTICK_BLACKLIST_DEVICES_EXCLUDED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_DEVICE => "SDL_JOYSTICK_DEVICE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_FLIGHTSTICK_DEVICES => "SDL_JOYSTICK_FLIGHTSTICK_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_FLIGHTSTICK_DEVICES_EXCLUDED => "SDL_JOYSTICK_FLIGHTSTICK_DEVICES_EXCLUDED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_GAMECUBE_DEVICES => "SDL_JOYSTICK_GAMECUBE_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_GAMECUBE_DEVICES_EXCLUDED => "SDL_JOYSTICK_GAMECUBE_DEVICES_EXCLUDED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI => "SDL_JOYSTICK_HIDAPI"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_COMBINE_JOY_CONS => "SDL_JOYSTICK_HIDAPI_COMBINE_JOY_CONS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE => "SDL_JOYSTICK_HIDAPI_GAMECUBE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE_RUMBLE_BRAKE => "SDL_JOYSTICK_HIDAPI_GAMECUBE_RUMBLE_BRAKE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_JOY_CONS => "SDL_JOYSTICK_HIDAPI_JOY_CONS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_JOYCON_HOME_LED => "SDL_JOYSTICK_HIDAPI_JOYCON_HOME_LED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_LUNA => "SDL_JOYSTICK_HIDAPI_LUNA"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_NINTENDO_CLASSIC => "SDL_JOYSTICK_HIDAPI_NINTENDO_CLASSIC"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS3 => "SDL_JOYSTICK_HIDAPI_PS3"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS3_SIXAXIS_DRIVER => "SDL_JOYSTICK_HIDAPI_PS3_SIXAXIS_DRIVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS4 => "SDL_JOYSTICK_HIDAPI_PS4"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS4_RUMBLE => "SDL_JOYSTICK_HIDAPI_PS4_RUMBLE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS5 => "SDL_JOYSTICK_HIDAPI_PS5"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS5_PLAYER_LED => "SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS5_RUMBLE => "SDL_JOYSTICK_HIDAPI_PS5_RUMBLE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_SHIELD => "SDL_JOYSTICK_HIDAPI_SHIELD"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_STADIA => "SDL_JOYSTICK_HIDAPI_STADIA"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_STEAM => "SDL_JOYSTICK_HIDAPI_STEAM"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_STEAMDECK => "SDL_JOYSTICK_HIDAPI_STEAMDECK"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_SWITCH => "SDL_JOYSTICK_HIDAPI_SWITCH"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_SWITCH_HOME_LED => "SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED => "SDL_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS => "SDL_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_WII => "SDL_JOYSTICK_HIDAPI_WII"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_WII_PLAYER_LED => "SDL_JOYSTICK_HIDAPI_WII_PLAYER_LED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX => "SDL_JOYSTICK_HIDAPI_XBOX"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_360 => "SDL_JOYSTICK_HIDAPI_XBOX_360"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED => "SDL_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_WIRELESS => "SDL_JOYSTICK_HIDAPI_XBOX_360_WIRELESS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE => "SDL_JOYSTICK_HIDAPI_XBOX_ONE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED => "SDL_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_IOKIT => "SDL_JOYSTICK_IOKIT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_LINUX_CLASSIC => "SDL_JOYSTICK_LINUX_CLASSIC"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_LINUX_DEADZONES => "SDL_JOYSTICK_LINUX_DEADZONES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_LINUX_DIGITAL_HATS => "SDL_JOYSTICK_LINUX_DIGITAL_HATS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_LINUX_HAT_DEADZONES => "SDL_JOYSTICK_LINUX_HAT_DEADZONES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_MFI => "SDL_JOYSTICK_MFI"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_RAWINPUT => "SDL_JOYSTICK_RAWINPUT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_RAWINPUT_CORRELATE_XINPUT => "SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_ROG_CHAKRAM => "SDL_JOYSTICK_ROG_CHAKRAM"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_THREAD => "SDL_JOYSTICK_THREAD"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_THROTTLE_DEVICES => "SDL_JOYSTICK_THROTTLE_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_THROTTLE_DEVICES_EXCLUDED => "SDL_JOYSTICK_THROTTLE_DEVICES_EXCLUDED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_WGI => "SDL_JOYSTICK_WGI"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_WHEEL_DEVICES => "SDL_JOYSTICK_WHEEL_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_WHEEL_DEVICES_EXCLUDED => "SDL_JOYSTICK_WHEEL_DEVICES_EXCLUDED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_ZERO_CENTERED_DEVICES => "SDL_JOYSTICK_ZERO_CENTERED_DEVICES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_KMSDRM_DEVICE_INDEX => "SDL_KMSDRM_DEVICE_INDEX"u8;
	public static ReadOnlySpan<byte> SDL_HINT_KMSDRM_REQUIRE_DRM_MASTER => "SDL_KMSDRM_REQUIRE_DRM_MASTER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_LOGGING => "SDL_LOGGING"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MAC_BACKGROUND_APP => "SDL_MAC_BACKGROUND_APP"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK => "SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MAC_OPENGL_ASYNC_DISPATCH => "SDL_MAC_OPENGL_ASYNC_DISPATCH"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MAIN_CALLBACK_RATE => "SDL_MAIN_CALBACK_RATE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_AUTO_CAPTURE => "SDL_MOUSE_AUTO_CAPTURE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_DOUBLE_CLICK_RADIUS => "SDL_MOUSE_DOUBLE_CLICK_RADIUS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_DOUBLE_CLICK_TIME => "SDL_MOUSE_DOUBLE_CLICK_TIME"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH => "SDL_MOUSE_FOCUS_CLICKTHROUGH"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_NORMAL_SPEED_SCALE => "SDL_MOUSE_NORMAL_SPEED_SCALE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_MODE_CENTER => "SDL_MOUSE_RELATIVE_MODE_CENTER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_MODE_WARP => "SDL_MOUSE_RELATIVE_MODE_WARP"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_SPEED_SCALE => "SDL_MOUSE_RELATIVE_SPEED_SCALE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_SYSTEM_SCALE => "SDL_MOUSE_RELATIVE_SYSTEM_SCALE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_WARP_MOTION => "SDL_MOUSE_RELATIVE_WARP_MOTION"u8;
	public static ReadOnlySpan<byte> SDL_HINT_MOUSE_TOUCH_EVENTS => "SDL_MOUSE_TOUCH_EVENTS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_NO_SIGNAL_HANDLERS => "SDL_NO_SIGNAL_HANDLERS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_OPENGL_ES_DRIVER => "SDL_OPENGL_ES_DRIVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_ORIENTATIONS => "SDL_IOS_ORIENTATIONS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_PEN_DELAY_MOUSE_BUTTON => "SDL_HINT_PEN_DELAY_MOUSE_BUTTON"u8;
	public static ReadOnlySpan<byte> SDL_HINT_PEN_NOT_MOUSE => "SDL_HINT_PEN_NOT_MOUSE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_POLL_SENTINEL => "SDL_POL_SENTINEL"u8;
	public static ReadOnlySpan<byte> SDL_HINT_PREFERRED_LOCALES => "SDL_PREFERRED_LOCALES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_QUIT_ON_LAST_WINDOW_CLOSE => "SDL_QUIT_ON_LAST_WINDOW_CLOSE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RENDER_DIRECT3D_THREADSAFE => "SDL_RENDER_DIRECT3D_THREADSAFE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RENDER_DIRECT3D11_DEBUG => "SDL_RENDER_DIRECT3D11_DEBUG"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RENDER_VULKAN_DEBUG => "SDL_RENDER_VULKAN_DEBUG"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RENDER_DRIVER => "SDL_RENDER_DRIVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RENDER_LINE_METHOD => "SDL_RENDER_LINE_METHOD"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RENDER_METAL_PREFER_LOW_POWER_DEVICE => "SDL_RENDER_METAL_PREFER_LOW_POWER_DEVICE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RENDER_PS2_DYNAMIC_VSYNC => "SDL_RENDER_PS2_DYNAMIC_VSYNC"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RENDER_VSYNC => "SDL_RENDER_VSYNC"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RETURN_KEY_HIDES_IME => "SDL_RETURN_KEY_HIDES_IME"u8;
	public static ReadOnlySpan<byte> SDL_HINT_ROG_GAMEPAD_MICE => "SDL_ROG_GAMEPAD_MICE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_ROG_GAMEPAD_MICE_EXCLUDED => "SDL_ROG_GAMEPAD_MICE_EXCLUDED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_RPI_VIDEO_LAYER => "SDL_RPI_VIDEO_LAYER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_SCREENSAVER_INHIBIT_ACTIVITY_NAME => "SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME"u8;
	public static ReadOnlySpan<byte> SDL_HINT_SHUTDOWN_DBUS_ON_QUIT => "SDL_SHUTDOWN_DBUS_ON_QUIT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_STORAGE_TITLE_DRIVER => "SDL_STORAGE_TITLE_DRIVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_STORAGE_USER_DRIVER => "SDL_STORAGE_USER_DRIVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_THREAD_FORCE_REALTIME_TIME_CRITICAL => "SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL"u8;
	public static ReadOnlySpan<byte> SDL_HINT_THREAD_PRIORITY_POLICY => "SDL_THREAD_PRIORITY_POLICY"u8;
	public static ReadOnlySpan<byte> SDL_HINT_TIMER_RESOLUTION => "SDL_TIMER_RESOLUTION"u8;
	public static ReadOnlySpan<byte> SDL_HINT_TOUCH_MOUSE_EVENTS => "SDL_TOUCH_MOUSE_EVENTS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_TRACKPAD_IS_TOUCH_ONLY => "SDL_TRACKPAD_IS_TOUCH_ONLY"u8;
	public static ReadOnlySpan<byte> SDL_HINT_TV_REMOTE_AS_JOYSTICK => "SDL_TV_REMOTE_AS_JOYSTICK"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_ALLOW_SCREENSAVER => "SDL_VIDEO_ALOW_SCREENSAVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_DOUBLE_BUFFER => "SDL_VIDEO_DOUBLE_BUFFER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_DRIVER => "SDL_VIDEO_DRIVER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_EGL_ALLOW_GETDISPLAY_FALLBACK => "SDL_VIDEO_EGL_GETDISPLAY_FALBACK"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_FORCE_EGL => "SDL_VIDEO_FORCE_EGL"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_MAC_FULLSCREEN_SPACES => "SDL_VIDEO_MAC_FULSCREEN_SPACES"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_MINIMIZE_ON_FOCUS_LOSS => "SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_SYNC_WINDOW_OPERATIONS => "SDL_VIDEO_SYNC_WINDOW_OPERATIONS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_ALLOW_LIBDECOR => "SDL_VIDEO_WAYLAND_ALOW_LIBDECOR"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_EMULATE_MOUSE_WARP => "SDL_VIDEO_WAYLAND_EMULATE_MOUSE_WARP"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_MODE_EMULATION => "SDL_VIDEO_WAYLAND_MODE_EMULATION"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_MODE_SCALING => "SDL_VIDEO_WAYLAND_MODE_SCALING"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_PREFER_LIBDECOR => "SDL_VIDEO_WAYLAND_PREFER_LIBDECOR"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_SCALE_TO_DISPLAY => "SDL_VIDEO_WAYLAND_SCALE_TO_DISPLAY"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WIN_D3DCOMPILER => "SDL_VIDEO_WIN_D3DCOMPILER"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR => "SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_NET_WM_PING => "SDL_VIDEO_X11_NET_WM_PING"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_SCALING_FACTOR => "SDL_VIDEO_X11_SCALING_FACTOR"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_WINDOW_VISUALID => "SDL_VIDEO_X11_WINDOW_VISUALID"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_XRANDR => "SDL_VIDEO_X11_XRANDR"u8;
	public static ReadOnlySpan<byte> SDL_HINT_VITA_TOUCH_MOUSE_DEVICE => "SDL_HINT_VITA_TOUCH_MOUSE_DEVICE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WAVE_FACT_CHUNK => "SDL_WAVE_FACT_CHUNK"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WAVE_RIFF_CHUNK_SIZE => "SDL_WAVE_RIFF_CHUNK_SIZE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WAVE_TRUNCATION => "SDL_WAVE_TRUNCATION"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOW_ACTIVATE_WHEN_RAISED => "SDL_WINDOW_ACTIVATE_WHEN_RAISED"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOW_ACTIVATE_WHEN_SHOWN => "SDL_WINDOW_ACTIVATE_WHEN_SHOWN"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOW_ALLOW_TOPMOST => "SDL_WINDOW_ALOW_TOPMOST"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN => "SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_ENABLE_MENU_MNEMONICS => "SDL_WINDOWS_ENABLE_MENU_MNEMONICS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_ENABLE_MESSAGELOOP => "SDL_WINDOWS_ENABLE_MESSAGELOOP"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS => "SDL_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_FORCE_SEMAPHORE_KERNEL => "SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_INTRESOURCE_ICON => "SDL_WINDOWS_INTRESOURCE_ICON"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_INTRESOURCE_ICON_SMALL => "SDL_WINDOWS_INTRESOURCE_ICON_SMAL"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_CLOSE_ON_ALT_F4 => "SDL_WINDOWS_CLOSE_ON_ALT_F4"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_USE_D3D9EX => "SDL_WINDOWS_USE_D3D9EX"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINRT_HANDLE_BACK_BUTTON => "SDL_WINRT_HANDLE_BACK_BUTTON"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINRT_PRIVACY_POLICY_LABEL => "SDL_WINRT_PRIVACY_POLICY_LABEL"u8;
	public static ReadOnlySpan<byte> SDL_HINT_WINRT_PRIVACY_POLICY_URL => "SDL_WINRT_PRIVACY_POLICY_URL"u8;
	public static ReadOnlySpan<byte> SDL_HINT_X11_FORCE_OVERRIDE_REDIRECT => "SDL_X11_FORCE_OVERRIDE_REDIRECT"u8;
	public static ReadOnlySpan<byte> SDL_HINT_X11_WINDOW_TYPE => "SDL_X11_WINDOW_TYPE"u8;
	public static ReadOnlySpan<byte> SDL_HINT_XINPUT_ENABLED => "SDL_XINPUT_ENABLED"u8;
	public const uint SDL_ALPHA_OPAQUE = 255;
	public const uint SDL_ALPHA_TRANSPARENT = 0;
	public const uint SDL_SWSURFACE = 0;
	public const uint SDL_PREALLOC = 0x00000001;
	public const uint SDL_RLEACCEL = 0x00000002;
	public const uint SDL_DONTFREE = 0x00000004;
	public const uint SDL_SIMD_ALIGNED = 0x00000008;
	public const uint SDL_SURFACE_USES_PROPERTIES = 0x00000010;
	public static ReadOnlySpan<byte> SDL_PROP_SURFACE_COLORSPACE_NUMBER => "SDL.surface.colorspace"u8;
	public static ReadOnlySpan<byte> SDL_PROP_SURFACE_SDR_WHITE_POINT_FLOAT => "SDL.surface.SDR_white_point"u8;
	public static ReadOnlySpan<byte> SDL_PROP_SURFACE_HDR_HEADROOM_FLOAT => "SDL.surface.HDR_headroom"u8;
	public static ReadOnlySpan<byte> SDL_PROP_SURFACE_TONEMAP_OPERATOR_STRING => "SDL.surface.tonemap"u8;
	public static ReadOnlySpan<byte> SDL_PROP_GLOBAL_SYSTEM_DATE_FORMAT_NUMBER => "SDL.time.date_format"u8;
	public static ReadOnlySpan<byte> SDL_PROP_GLOBAL_SYSTEM_TIME_FORMAT_NUMBER => "SDL.time.time_format"u8;
}
