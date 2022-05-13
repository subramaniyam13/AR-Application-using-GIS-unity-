import arcpy
from arcpy import env
from arcpy.sa import *
arcpy.env.workspace=r"C:\Users\Subramaniyam\Documents\python\Leastcost"


Raster="ASTGTMV003_N27E088_dem.tif"

output="Contour11.shp"
c_interval=250
base=0
zfactor=1
op="DEGREE"
Contour(Raster,output,c_interval,base,zfactor)

op_slope=Slope(Raster,op,zfactor)
op_slope.save("slope1.tif")

op_aspect=Aspect(Raster)
op_aspect.save("Aspect.tif")



