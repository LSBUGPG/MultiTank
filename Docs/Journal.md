# Learning journal

## 13/3/2018

Today I learned that by default when building on Android, Unity uses a newer texture compression format called ETC2. If you have an older Android device that doesn't support this newer format, then it unpacks the texture on the device so you have both the compressed and uncompressed version in the devices memory. This is particularly a problem on older Android devices as they tend to have less memory anyway.

You can override this default behaviour in the texture import settings by clicking override and choosing ETC format. This works for textures without alpha channels. For textures with alpha channels you also need to tick the split alpha texture box, supply a packing tag for the textures, and run the legacy texture packing tool.
