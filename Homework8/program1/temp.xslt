<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	
	<xsl:template match="/">
				<html>
					<body>
						<h1>Orders</h1>
						<ul>
							<xsl:for-each select="ArrayOfOrder/Order">
								<li><xsl:value-of select="ID"/></li>
								<li><xsl:value-of select="CustomerName"/></li>
								<li><xsl:value-of select="PhoneNum"/></li>
								<li>
									<font>OrderDetails</font><br/>
									<font>OrderThings</font><br/>
									<!--<ul>
										<li><font>Good:</font></li>
										<xsl:for-each select="OrderDetails/OrderThings/Good">	
											<li><font>Name:</font><xsl:value-of select="Name"/></li>
											<li><font>Id:</font><xsl:value-of select="Id"/></li>
											<li><font>Quantity:</font><xsl:value-of select="Quantity"/></li>
											<li><font>UPrice:</font><xsl:value-of select="UPrice"/></li>
											<li><font>TPrice:</font><xsl:value-of select="TPrice"/></li>
										</xsl:for-each>
									</ul><br/>-->
									<xsl:choose>
											<xsl:when test="OrderDetails/OrderThings/Good">
												<ul>										
													<xsl:for-each select="OrderDetails/OrderThings/Good">	
														<li><font>Name:</font><xsl:value-of select="Name"/></li>
														<li><font>Id:</font><xsl:value-of select="Id"/></li>
														<li><font>Quantity:</font><xsl:value-of select="Quantity"/></li>
														<li><font>UPrice:</font><xsl:value-of select="UPrice"/></li>
														<li><font>TPrice:</font><xsl:value-of select="TPrice"/></li>
													</xsl:for-each>	
												</ul>								
											</xsl:when>
											<xsl:otherwise></xsl:otherwise>
									</xsl:choose>
									<font>TotalPrice:<xsl:value-of select="OrderDetails/OrderThings/TotalPrice"/></font>
								</li><br/>								
							</xsl:for-each>
						</ul>
					</body>
				</html>
	</xsl:template>

</xsl:stylesheet>
