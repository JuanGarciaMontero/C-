
1- 2 listas no ordenadas, una con el nombre las películas y otras con las series.

<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/">
<html>
<head/>
<body>
<xsl:apply-templates/>
</body>
</html>
</xsl:template>
<xsl:template match="peliculas">
<ul>
<xsl:apply-templates/>
</ul>
</xsl:template>
<xsl:template match="pelicula">
<li>
<xsl:value-of select="nombre"/>
</li>
</xsl:template>
<xsl:template match="series">
<ul>
<xsl:apply-templates/>
</ul>
</xsl:template>
<xsl:template match="serie">
<li>
<xsl:value-of select="nombre"/>
</li>
</xsl:template>
</xsl:stylesheet>

2- Una única lista no ordenada con el nombre de todas las peliculas y series

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/">
<html>
<head/>
<body>
    <ul><xsl:apply-templates/></ul>
</body>
</html>
</xsl:template>
<xsl:template match="peliculas">
<xsl:apply-templates/>
</xsl:template>
<xsl:template match="pelicula">
<li>
<xsl:value-of select="nombre"/>
</li>
</xsl:template>
<xsl:template match="series">

<xsl:apply-templates/>

</xsl:template>
<xsl:template match="serie">
<li>
<xsl:value-of select="nombre"/>
</li>
</xsl:template>
</xsl:stylesheet>


3- Hacer una tabla con las películas y otra con las series indicando el nombre, director, valoración y público

<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    
<xsl:template match="netflix">
    <html><head></head>
    <body>
    <xsl:apply-templates/>
        
      </body>  
    </html>
</xsl:template>
<xsl:template match="peliculas">
<table border="1">
        <tr>
          <th>Nombre</th>
          <th>Director</th>
          <th>Valoración</th>
          <th>Público</th>
        </tr>
    <xsl:apply-templates/>
    </table>
</xsl:template>

<xsl:template match="pelicula">
    
    <tr>
        <td><xsl:value-of select="nombre"/></td>
        <td><xsl:value-of select="director"/></td>
        <td><xsl:value-of select="valoracion/@puntos"/></td>
        <td><xsl:value-of select="publico"/></td>
    </tr>
</xsl:template>

<xsl:template match="series">
<table border="1">
        <tr>
          <th>Nombre</th>
          <th>Director</th>
          <th>Valoración</th>
          <th>Público</th>
        </tr>
    <xsl:apply-templates/>
    </table>
</xsl:template>
    
    <xsl:template match="serie">
        
    <tr>
        <td><xsl:value-of select="nombre"/></td>
        <td><xsl:value-of select="director"/></td>
        <td><xsl:value-of select="valoracion/@puntos"/></td>
        <td><xsl:value-of select="publico"/></td>
    </tr>
</xsl:template>

</xsl:stylesheet>

4- Hacer una única tabla con peículas y series y resto de datos de cada una

<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    
<xsl:template match="netflix">
    <html><head></head>
    <body>
    <table border="1">
        <tr>
          <th>Nombre</th>
          <th>Director</th>
          <th>Valoración</th>
          <th>Público</th>
        </tr>
    <xsl:apply-templates/>
    </table>      
      </body>  
    </html>
</xsl:template>

<xsl:template match="pelicula">
    
    <tr>
        <td><xsl:value-of select="nombre"/></td>
        <td><xsl:value-of select="director"/></td>
        <td><xsl:value-of select="valoracion/@puntos"/></td>
        <td><xsl:value-of select="publico"/></td>
    </tr>
</xsl:template>
    
    <xsl:template match="serie">
        
    <tr>
        <td><xsl:value-of select="nombre"/></td>
        <td><xsl:value-of select="director"/></td>
        <td><xsl:value-of select="valoracion/@puntos"/></td>
        <td><xsl:value-of select="publico"/></td>
    </tr>
</xsl:template>

</xsl:stylesheet>


5- Documento con Nombre de la serie o película en h1, el director en h2 y público en h3

<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/">
<html>
<head/>
<body>
<xsl:apply-templates/>
</body>
</html>
</xsl:template>
<xsl:template match="pelicula">
<h1>
<xsl:value-of select="nombre"/>
</h1>
<h2>
<xsl:value-of select="director"/>
</h2>
<h3>
<xsl:value-of select="publico"/>
</h3>
</xsl:template>
<xsl:template match="serie">
<h1>
<xsl:value-of select="nombre"/>
</h1>
<h2>
<xsl:value-of select="director"/>
</h2>
<h3>
<xsl:value-of select="publico"/>
</h3>
</xsl:template>
</xsl:stylesheet>




6- XML igual al origuinal donde la etiqueta valoración pase a ser un atributo del nombre: 
<nombre valoracion="x">blabla</nombre>

<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/">
<netflix>
<xsl:apply-templates/>
</netflix>
</xsl:template>
<xsl:template match="peliculas">
<peliculas>
<xsl:apply-templates/>
</peliculas>
</xsl:template>
<xsl:template match="pelicula">
<pelicula>
<nombre>
<xsl:value-of select="nombre"/>
</nombre>
<director>
<xsl:value-of select="director"/>
</director>
<xsl:attribute name="valoracion">
<xsl:value-of select="valoracion/@puntos"/>
</xsl:attribute>        
<publico>
<xsl:value-of select="publico"/>
</publico>
</pelicula>
</xsl:template>
<xsl:template match="series">
<series>
<xsl:apply-templates/>
</series>
</xsl:template>
<xsl:template match="serie">
<serie>
<nombre>
<xsl:value-of select="nombre"/>
</nombre>
<director>
<xsl:value-of select="director"/>
</director>
<xsl:attribute name="valoracion">
<xsl:value-of select="valoracion/@puntos"/>
</xsl:attribute>
<publico>
<xsl:value-of select="publico"/>
</publico>
</serie>
</xsl:template>
</xsl:stylesheet>






