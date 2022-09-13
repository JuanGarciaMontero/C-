<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
   
 <xsl:template match="/"> 
     <html>
         <head></head>
            <body>
                <h2><Strong>Carta_Desayuno</Strong></h2><br/>
                <table border="1">
                    <tr>
                        <th><Strong>Nombre</Strong></th>
                        <th><Strong>Precio</Strong></th>
                        <th><Strong>Descripcion</Strong></th>
                        <th><Strong>Calorias</Strong></th>
                    </tr>
     <xsl:apply-templates/>
                </table>
            </body>
     </html>
</xsl:template>   
<xsl:template match="tipo">
       <tr>
           <td><xsl:value-of select="nombre"/></td>
            <td><xsl:value-of select="precio"/>
           </td>
            <td><xsl:value-of select="descripcion"/>
           </td>
            <td><xsl:value-of select="calorias"/>
           </td>
        </tr>
</xsl:template>        
</xsl:stylesheet>