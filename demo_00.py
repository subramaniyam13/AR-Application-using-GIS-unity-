import arcpy
arcpy.env.workspace="C:\Users\Subramaniyam\Documents\python"

input="Places_TN.shp"
clip="kodaikanal.shp"
output_clip="places_in_kodaikanal00441.shp"

arcpy.Clip_analysis(input,clip,output_clip)

out_select="selection00.shp"
arcpy.Select_analysis(output_clip,out_select,"FID>1")


arcpy.Buffer_analysis(out_select,"buffer_places.shp","500 meters",)

