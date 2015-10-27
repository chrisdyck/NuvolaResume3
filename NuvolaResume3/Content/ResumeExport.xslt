<?xml version="1.0" ?>
<xsl:stylesheet version="1.0"
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
      xmlns:dt="urn:schemas-microsoft-com:datatypes"
    xmlns:ms="urn:schemas-microsoft-com:xslt"
               
>

  <xsl:output method="xml" indent="yes" standalone="yes" encoding="utf-8"/>
  <xsl:template match="/">
    <!--<xsl:text disable-output-escaping="yes"><![CDATA[<?xml version="1.0" encoding="UTF-8" standalone="yes"?>]]></xsl:text>-->
    <xsl:text disable-output-escaping="yes"><![CDATA[<?mso-application progid="Word.Document"?>]]></xsl:text>
    <pkg:package xmlns:pkg="http://schemas.microsoft.com/office/2006/xmlPackage">
      <pkg:part pkg:name="/_rels/.rels" pkg:contentType="application/vnd.openxmlformats-package.relationships+xml" pkg:padding="512">
        <pkg:xmlData>
          <Relationships xmlns="http://schemas.openxmlformats.org/package/2006/relationships">
            <Relationship Id="rId3" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties" Target="docProps/app.xml"/>
            <Relationship Id="rId2" Type="http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties" Target="docProps/core.xml"/>
            <Relationship Id="rId1" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument" Target="word/document.xml"/>
          </Relationships>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/_rels/document.xml.rels" pkg:contentType="application/vnd.openxmlformats-package.relationships+xml" pkg:padding="256">
        <pkg:xmlData>
          <Relationships xmlns="http://schemas.openxmlformats.org/package/2006/relationships">
            <Relationship Id="rId8" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/header" Target="header1.xml"/>
            <Relationship Id="rId13" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer" Target="footer3.xml"/>
            <Relationship Id="rId3" Type="http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects" Target="stylesWithEffects.xml"/>
            <Relationship Id="rId7" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes" Target="endnotes.xml"/>
            <Relationship Id="rId12" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/header" Target="header3.xml"/>
            <Relationship Id="rId2" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles" Target="styles.xml"/>
            <Relationship Id="rId1" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering" Target="numbering.xml"/>
            <Relationship Id="rId6" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes" Target="footnotes.xml"/>
            <Relationship Id="rId11" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer" Target="footer2.xml"/>
            <Relationship Id="rId5" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings" Target="webSettings.xml"/>
            <Relationship Id="rId15" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme" Target="theme/theme1.xml"/>
            <Relationship Id="rId10" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer" Target="footer1.xml"/>
            <Relationship Id="rId4" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings" Target="settings.xml"/>
            <Relationship Id="rId9" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/header" Target="header2.xml"/>
            <Relationship Id="rId14" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable" Target="fontTable.xml"/>
          </Relationships>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/document.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml">
        <pkg:xmlData>
          <w:document mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:body>
              <w:p w:rsidR="00555025" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                <w:pPr>
                  <w:pStyle w:val="Heading1"/>
                </w:pPr>
                <w:r>
                  <w:t>Summary</w:t>
                </w:r>
              </w:p>
              <w:p w:rsidR="00D912F0" w:rsidRDefault="002A6754" w:rsidP="000B37CF">
                <w:proofErr w:type="spellStart"/>
                <w:r>
                  <w:t>
                    <xsl:value-of select="ResumeOutputModel/Resume/SummaryObjectives"/>
                  </w:t>
                </w:r>
                <w:proofErr w:type="spellEnd"/>
              </w:p>
              <xsl:if test="count(ResumeOutputModel/ResumeAchievementsView_Results/ResumeAchievements_GetAll_Result) > 0">
                <w:p w:rsidR="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                  <w:pPr>
                    <w:pStyle w:val="Heading1"/>
                  </w:pPr>
                  <w:r>
                    <w:t>Achievements</w:t>
                  </w:r>
                </w:p>
                <xsl:for-each select="ResumeOutputModel/ResumeAchievementsView_Results/ResumeAchievements_GetAll_Result">
                  <w:p w:rsidR="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                    <w:pPr>
                      <w:pStyle w:val="ListParagraph"/>
                      <w:numPr>
                        <w:ilvl w:val="0"/>
                        <w:numId w:val="1"/>
                      </w:numPr>
                    </w:pPr>
                    <w:r>
                      <w:t>
                        <xsl:value-of select="Name"/>
                      </w:t>
                    </w:r>
                  </w:p>
                </xsl:for-each>
              </xsl:if>
              <xsl:if test="count(ResumeOutputModel/Resume_GetAllSkills_Results/Resume_GetAllSkills_Result) > 0">
                <w:p w:rsidR="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                  <w:pPr>
                    <w:pStyle w:val="Heading1"/>
                  </w:pPr>
                  <w:r>
                    <w:t>Career Experience</w:t>
                  </w:r>
                </w:p>
                <xsl:for-each select="ResumeOutputModel/Resume_GetAllSkills_Results/Resume_GetAllSkills_Result">
                  <xsl:variable name="prevCompanyName">
                    <xsl:value-of select="preceding::CompanyName[position()=1]"/>
                  </xsl:variable>
                  <xsl:variable name="prevJobTitle">
                    <xsl:value-of select="preceding::JobTitle[position()=1]"/>
                  </xsl:variable>
                  <xsl:if test="$prevCompanyName!=CompanyName">
                    <w:p w:rsidR="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="000B37CF">
                      <w:pPr>
                        <w:pStyle w:val="Heading2"/>
                      </w:pPr>
                      <w:r>
                        <w:t xml:space="preserve"><xsl:value-of select="CompanyName"/></w:t>
                      </w:r>
                    </w:p>
                  </xsl:if>
                  <xsl:if test="$prevJobTitle!=JobTitle">
                    <w:p w:rsidR="00D912F0" w:rsidRPr="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="000B37CF">
                      <w:pPr>
                        <w:pStyle w:val="Heading3"/>
                      </w:pPr>
                      <w:r>
                        <w:t>
                          <xsl:value-of select="JobTitle"/>
                        </w:t>
                      </w:r>
                      <w:r w:rsidRPr="000B37CF">
                        <w:rPr>
                          <w:rStyle w:val="JobDates"/>
                        </w:rPr>
                        <w:t>
                          <xsl:text disable-output-escaping="yes">&#160;&#160;(</xsl:text>
                          <xsl:value-of select="ms:format-date(DateStart, 'MMM, yyyy')"/>
                          <xsl:text> - </xsl:text>
                          <xsl:choose>
                            <xsl:when test="DateEnd=''">
                              <xsl:text>Present</xsl:text>
                            </xsl:when>
                            <xsl:otherwise>
                              <xsl:value-of select="ms:format-date(DateEnd, 'MMM, yyyy')"/>
                            </xsl:otherwise>
                          </xsl:choose>
                          <xsl:text>)</xsl:text>
                        </w:t>
                      </w:r>
                    </w:p>
                  </xsl:if>
                  <w:p w:rsidR="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                    <w:pPr>
                      <w:pStyle w:val="ListParagraph"/>
                      <w:numPr>
                        <w:ilvl w:val="0"/>
                        <w:numId w:val="1"/>
                      </w:numPr>
                    </w:pPr>
                    <w:r>
                      <w:t>
                        <xsl:value-of select="Description"/>
                      </w:t>
                    </w:r>
                  </w:p>
                </xsl:for-each>
              </xsl:if>
              <xsl:if test="count(ResumeOutputModel/ResumeEducationsView_Results/ResumeEducations_GetAll_Result) > 0">
                <w:p w:rsidR="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                  <w:pPr>
                    <w:pStyle w:val="Heading1"/>
                  </w:pPr>
                  <w:r>
                    <w:t>Education</w:t>
                  </w:r>
                </w:p>
                <xsl:for-each select="ResumeOutputModel/ResumeEducationsView_Results/ResumeEducations_GetAll_Result">
                  <w:p w:rsidR="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                    <w:pPr>
                      <w:pStyle w:val="ListParagraph"/>
                      <w:numPr>
                        <w:ilvl w:val="0"/>
                        <w:numId w:val="1"/>
                      </w:numPr>
                    </w:pPr>
                    <w:r>
                      <w:t>
                        <xsl:value-of select="CourseName"/>
                        <xsl:text>,&#160;</xsl:text>
                        <xsl:value-of select="InstitutionName"/>
                        <xsl:text>&#160;(</xsl:text>
                        <xsl:choose>
                          <xsl:when test="DateEnd=''">
                            <xsl:text>Present</xsl:text>
                          </xsl:when>
                          <xsl:otherwise>
                            <xsl:value-of select="ms:format-date(DateEnd, 'yyyy')"/>
                          </xsl:otherwise>
                        </xsl:choose>
                        <xsl:text>)</xsl:text>
                      </w:t>
                    </w:r>
                  </w:p>
                </xsl:for-each>
              </xsl:if>

              <xsl:if test="count(ResumeOutputModel/ResumeVolunteerExperiencesView_Results/ResumeVolunteerExperiences_GetAll_Result) > 0">
                <w:p w:rsidR="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                  <w:pPr>
                    <w:pStyle w:val="Heading1"/>
                  </w:pPr>
                  <w:r>
                    <w:t>Volunteer Experience</w:t>
                  </w:r>
                </w:p>
                <xsl:for-each select="ResumeOutputModel/ResumeVolunteerExperiencesView_Results/ResumeVolunteerExperiences_GetAll_Result">
                  <w:p w:rsidR="00D912F0" w:rsidRPr="00D912F0" w:rsidRDefault="00D912F0" w:rsidP="00D912F0">
                    <w:pPr>
                      <w:pStyle w:val="ListParagraph"/>
                      <w:numPr>
                        <w:ilvl w:val="0"/>
                        <w:numId w:val="1"/>
                      </w:numPr>
                    </w:pPr>
                    <w:r>
                      <w:t>
                        <xsl:value-of select="VolunteerExperienceName"/>
                      </w:t>
                    </w:r>
                  </w:p>
                </xsl:for-each>
              </xsl:if>
              <w:sectPr w:rsidR="00D912F0" w:rsidRPr="00D912F0">
                <w:headerReference w:type="even" r:id="rId8"/>
                <w:headerReference w:type="default" r:id="rId9"/>
                <w:footerReference w:type="even" r:id="rId10"/>
                <w:footerReference w:type="default" r:id="rId11"/>
                <w:headerReference w:type="first" r:id="rId12"/>
                <w:footerReference w:type="first" r:id="rId13"/>
                <w:pgSz w:w="12240" w:h="15840"/>
                <w:pgMar w:top="1440" w:right="1440" w:bottom="1440" w:left="1440" w:header="720" w:footer="720" w:gutter="0"/>
                <w:cols w:space="720"/>
                <w:docGrid w:linePitch="360"/>
              </w:sectPr>
            </w:body>
          </w:document>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/footer3.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml">
        <pkg:xmlData>
          <w:ftr mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:p w:rsidR="009E2D5F" w:rsidRDefault="009E2D5F">
              <w:pPr>
                <w:pStyle w:val="Footer"/>
              </w:pPr>
            </w:p>
          </w:ftr>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/footer2.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml">
        <pkg:xmlData>
          <w:ftr mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:p w:rsidR="009E2D5F" w:rsidRPr="00C63E00" w:rsidRDefault="00C63E00" w:rsidP="00C63E00">
              <w:r>
                <w:t xml:space="preserve">Resume of <xsl:value-of select="ResumeOutputModel/UserProfile/FirstName"/><xsl:text disable-output-escaping="yes"> </xsl:text><xsl:value-of select="ResumeOutputModel/UserProfile/LastName"/>
                </w:t>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:ptab w:relativeTo="margin" w:alignment="right" w:leader="none"/>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:t xml:space="preserve">Page </w:t>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:rPr>
                  <w:rFonts w:eastAsiaTheme="minorEastAsia"/>
                </w:rPr>
                <w:fldChar w:fldCharType="begin"/>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:instrText xml:space="preserve"> PAGE   \* MERGEFORMAT </w:instrText>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:rPr>
                  <w:rFonts w:eastAsiaTheme="minorEastAsia"/>
                </w:rPr>
                <w:fldChar w:fldCharType="separate"/>
              </w:r>
              <w:r w:rsidR="005777CF">
                <w:rPr>
                  <w:noProof/>
                </w:rPr>
                <w:t>1</w:t>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:rPr>
                  <w:noProof/>
                </w:rPr>
                <w:fldChar w:fldCharType="end"/>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:rPr>
                  <w:noProof/>
                </w:rPr>
                <w:t xml:space="preserve"> of </w:t>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:rPr>
                  <w:noProof/>
                </w:rPr>
                <w:fldChar w:fldCharType="begin"/>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:rPr>
                  <w:noProof/>
                </w:rPr>
                <w:instrText xml:space="preserve"> NUMPAGES  \* Arabic  \* MERGEFORMAT </w:instrText>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:rPr>
                  <w:noProof/>
                </w:rPr>
                <w:fldChar w:fldCharType="separate"/>
              </w:r>
              <w:r w:rsidR="005777CF">
                <w:rPr>
                  <w:noProof/>
                </w:rPr>
                <w:t>1</w:t>
              </w:r>
              <w:r w:rsidR="009E2D5F">
                <w:rPr>
                  <w:noProof/>
                </w:rPr>
                <w:fldChar w:fldCharType="end"/>
              </w:r>
            </w:p>
            <w:p w:rsidR="00DD7F7E" w:rsidRDefault="00DD7F7E">
              <w:pPr>
                <w:pStyle w:val="Footer"/>
              </w:pPr>
            </w:p>
          </w:ftr>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/footer1.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml">
        <pkg:xmlData>
          <w:ftr mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:p w:rsidR="009E2D5F" w:rsidRDefault="009E2D5F">
              <w:pPr>
                <w:pStyle w:val="Footer"/>
              </w:pPr>
            </w:p>
          </w:ftr>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/header2.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml">
        <pkg:xmlData>
          <w:hdr mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:p w:rsidR="00DD7F7E" w:rsidRDefault="005777CF" w:rsidP="005777CF">
              <w:pPr>
                <w:pStyle w:val="HeaderTitle"/>
              </w:pPr>
              <w:r w:rsidR="00D912F0">
                <w:t>
                  Resume of <xsl:value-of select="ResumeOutputModel/UserProfile/FirstName"/><xsl:text disable-output-escaping="yes"> </xsl:text><xsl:value-of select="ResumeOutputModel/UserProfile/LastName"/>
                </w:t>
              </w:r>
            </w:p>
            <w:p w:rsidR="00D912F0" w:rsidRPr="005777CF" w:rsidRDefault="005777CF" w:rsidP="005777CF">
              <w:pPr>
                <w:pStyle w:val="HeaderText1"/>
              </w:pPr>
              <w:proofErr w:type="gramStart"/>
              <w:r w:rsidRPr="005777CF">
                <w:t>t</w:t>
              </w:r>
              <w:proofErr w:type="gramEnd"/>
              <w:r w:rsidRPr="005777CF">
                <w:t xml:space="preserve">: </w:t>
              </w:r>
              <w:proofErr w:type="spellStart"/>
              <w:r w:rsidRPr="005777CF">
                <w:t>
                  <xsl:value-of select="ResumeOutputModel/UserProfile/PhoneNumber1"/>
                </w:t>
              </w:r>
              <w:proofErr w:type="spellEnd"/>
              <w:r w:rsidRPr="005777CF">
                <w:t xml:space="preserve">    </w:t>
              </w:r>
              <w:r w:rsidR="00D912F0" w:rsidRPr="005777CF">
                <w:t xml:space="preserve">e: </w:t>
              </w:r>
              <w:proofErr w:type="spellStart"/>
              <w:r w:rsidR="00D912F0" w:rsidRPr="005777CF">
                <w:t>
                  <xsl:value-of select="ResumeOutputModel/UserProfile/EMailAddress1"/>
                </w:t>
              </w:r>
              <w:proofErr w:type="spellEnd"/>
            </w:p>
            <w:p w:rsidR="003C1EAC" w:rsidRPr="005777CF" w:rsidRDefault="003C1EAC" w:rsidP="005777CF">
              <w:pPr>
                <w:pStyle w:val="HeaderText1"/>
              </w:pPr>
            </w:p>
            <w:p w:rsidR="004932B7" w:rsidRPr="005777CF" w:rsidRDefault="00D25DED" w:rsidP="003C1EAC">
              <w:pPr>
                <w:pStyle w:val="TagLine"/>
              </w:pPr>
              <w:r>
                <w:t>
                  <xsl:value-of select="ResumeOutputModel/Resume/TagLine"/>
                </w:t>
              </w:r>
            </w:p>
          </w:hdr>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/header1.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml">
        <pkg:xmlData>
          <w:hdr mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:p w:rsidR="009E2D5F" w:rsidRDefault="009E2D5F">
              <w:pPr>
                <w:pStyle w:val="Header"/>
              </w:pPr>
            </w:p>
          </w:hdr>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/endnotes.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml">
        <pkg:xmlData>
          <w:endnotes mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:endnote w:type="separator" w:id="-1">
              <w:p w:rsidR="00A250A6" w:rsidRDefault="00A250A6">
                <w:pPr>
                  <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
                </w:pPr>
                <w:r>
                  <w:separator/>
                </w:r>
              </w:p>
            </w:endnote>
            <w:endnote w:type="continuationSeparator" w:id="0">
              <w:p w:rsidR="00A250A6" w:rsidRDefault="00A250A6">
                <w:pPr>
                  <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
                </w:pPr>
                <w:r>
                  <w:continuationSeparator/>
                </w:r>
              </w:p>
            </w:endnote>
          </w:endnotes>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/footnotes.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml">
        <pkg:xmlData>
          <w:footnotes mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:footnote w:type="separator" w:id="-1">
              <w:p w:rsidR="00A250A6" w:rsidRDefault="00A250A6">
                <w:pPr>
                  <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
                </w:pPr>
                <w:r>
                  <w:separator/>
                </w:r>
              </w:p>
            </w:footnote>
            <w:footnote w:type="continuationSeparator" w:id="0">
              <w:p w:rsidR="00A250A6" w:rsidRDefault="00A250A6">
                <w:pPr>
                  <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
                </w:pPr>
                <w:r>
                  <w:continuationSeparator/>
                </w:r>
              </w:p>
            </w:footnote>
          </w:footnotes>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/header3.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml">
        <pkg:xmlData>
          <w:hdr mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:p w:rsidR="005777CF" w:rsidRDefault="005777CF">
              <w:pPr>
                <w:pStyle w:val="Header"/>
              </w:pPr>
            </w:p>
          </w:hdr>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/theme/theme1.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.theme+xml">
        <pkg:xmlData>
          <a:theme name="Office Theme" xmlns:a="http://schemas.openxmlformats.org/drawingml/2006/main">
            <a:themeElements>
              <a:clrScheme name="Office">
                <a:dk1>
                  <a:sysClr val="windowText" lastClr="000000"/>
                </a:dk1>
                <a:lt1>
                  <a:sysClr val="window" lastClr="FFFFFF"/>
                </a:lt1>
                <a:dk2>
                  <a:srgbClr val="1F497D"/>
                </a:dk2>
                <a:lt2>
                  <a:srgbClr val="EEECE1"/>
                </a:lt2>
                <a:accent1>
                  <a:srgbClr val="4F81BD"/>
                </a:accent1>
                <a:accent2>
                  <a:srgbClr val="C0504D"/>
                </a:accent2>
                <a:accent3>
                  <a:srgbClr val="9BBB59"/>
                </a:accent3>
                <a:accent4>
                  <a:srgbClr val="8064A2"/>
                </a:accent4>
                <a:accent5>
                  <a:srgbClr val="4BACC6"/>
                </a:accent5>
                <a:accent6>
                  <a:srgbClr val="F79646"/>
                </a:accent6>
                <a:hlink>
                  <a:srgbClr val="0000FF"/>
                </a:hlink>
                <a:folHlink>
                  <a:srgbClr val="800080"/>
                </a:folHlink>
              </a:clrScheme>
              <a:fontScheme name="Office">
                <a:majorFont>
                  <a:latin typeface="Cambria"/>
                  <a:ea typeface=""/>
                  <a:cs typeface=""/>
                  <a:font script="Jpan" typeface="ＭＳ ゴシック"/>
                  <a:font script="Hang" typeface="맑은 고딕"/>
                  <a:font script="Hans" typeface="宋体"/>
                  <a:font script="Hant" typeface="新細明體"/>
                  <a:font script="Arab" typeface="Times New Roman"/>
                  <a:font script="Hebr" typeface="Times New Roman"/>
                  <a:font script="Thai" typeface="Angsana New"/>
                  <a:font script="Ethi" typeface="Nyala"/>
                  <a:font script="Beng" typeface="Vrinda"/>
                  <a:font script="Gujr" typeface="Shruti"/>
                  <a:font script="Khmr" typeface="MoolBoran"/>
                  <a:font script="Knda" typeface="Tunga"/>
                  <a:font script="Guru" typeface="Raavi"/>
                  <a:font script="Cans" typeface="Euphemia"/>
                  <a:font script="Cher" typeface="Plantagenet Cherokee"/>
                  <a:font script="Yiii" typeface="Microsoft Yi Baiti"/>
                  <a:font script="Tibt" typeface="Microsoft Himalaya"/>
                  <a:font script="Thaa" typeface="MV Boli"/>
                  <a:font script="Deva" typeface="Mangal"/>
                  <a:font script="Telu" typeface="Gautami"/>
                  <a:font script="Taml" typeface="Latha"/>
                  <a:font script="Syrc" typeface="Estrangelo Edessa"/>
                  <a:font script="Orya" typeface="Kalinga"/>
                  <a:font script="Mlym" typeface="Kartika"/>
                  <a:font script="Laoo" typeface="DokChampa"/>
                  <a:font script="Sinh" typeface="Iskoola Pota"/>
                  <a:font script="Mong" typeface="Mongolian Baiti"/>
                  <a:font script="Viet" typeface="Times New Roman"/>
                  <a:font script="Uigh" typeface="Microsoft Uighur"/>
                  <a:font script="Geor" typeface="Sylfaen"/>
                </a:majorFont>
                <a:minorFont>
                  <a:latin typeface="Calibri"/>
                  <a:ea typeface=""/>
                  <a:cs typeface=""/>
                  <a:font script="Jpan" typeface="ＭＳ 明朝"/>
                  <a:font script="Hang" typeface="맑은 고딕"/>
                  <a:font script="Hans" typeface="宋体"/>
                  <a:font script="Hant" typeface="新細明體"/>
                  <a:font script="Arab" typeface="Arial"/>
                  <a:font script="Hebr" typeface="Arial"/>
                  <a:font script="Thai" typeface="Cordia New"/>
                  <a:font script="Ethi" typeface="Nyala"/>
                  <a:font script="Beng" typeface="Vrinda"/>
                  <a:font script="Gujr" typeface="Shruti"/>
                  <a:font script="Khmr" typeface="DaunPenh"/>
                  <a:font script="Knda" typeface="Tunga"/>
                  <a:font script="Guru" typeface="Raavi"/>
                  <a:font script="Cans" typeface="Euphemia"/>
                  <a:font script="Cher" typeface="Plantagenet Cherokee"/>
                  <a:font script="Yiii" typeface="Microsoft Yi Baiti"/>
                  <a:font script="Tibt" typeface="Microsoft Himalaya"/>
                  <a:font script="Thaa" typeface="MV Boli"/>
                  <a:font script="Deva" typeface="Mangal"/>
                  <a:font script="Telu" typeface="Gautami"/>
                  <a:font script="Taml" typeface="Latha"/>
                  <a:font script="Syrc" typeface="Estrangelo Edessa"/>
                  <a:font script="Orya" typeface="Kalinga"/>
                  <a:font script="Mlym" typeface="Kartika"/>
                  <a:font script="Laoo" typeface="DokChampa"/>
                  <a:font script="Sinh" typeface="Iskoola Pota"/>
                  <a:font script="Mong" typeface="Mongolian Baiti"/>
                  <a:font script="Viet" typeface="Arial"/>
                  <a:font script="Uigh" typeface="Microsoft Uighur"/>
                  <a:font script="Geor" typeface="Sylfaen"/>
                </a:minorFont>
              </a:fontScheme>
              <a:fmtScheme name="Office">
                <a:fillStyleLst>
                  <a:solidFill>
                    <a:schemeClr val="phClr"/>
                  </a:solidFill>
                  <a:gradFill rotWithShape="1">
                    <a:gsLst>
                      <a:gs pos="0">
                        <a:schemeClr val="phClr">
                          <a:tint val="50000"/>
                          <a:satMod val="300000"/>
                        </a:schemeClr>
                      </a:gs>
                      <a:gs pos="35000">
                        <a:schemeClr val="phClr">
                          <a:tint val="37000"/>
                          <a:satMod val="300000"/>
                        </a:schemeClr>
                      </a:gs>
                      <a:gs pos="100000">
                        <a:schemeClr val="phClr">
                          <a:tint val="15000"/>
                          <a:satMod val="350000"/>
                        </a:schemeClr>
                      </a:gs>
                    </a:gsLst>
                    <a:lin ang="16200000" scaled="1"/>
                  </a:gradFill>
                  <a:gradFill rotWithShape="1">
                    <a:gsLst>
                      <a:gs pos="0">
                        <a:schemeClr val="phClr">
                          <a:shade val="51000"/>
                          <a:satMod val="130000"/>
                        </a:schemeClr>
                      </a:gs>
                      <a:gs pos="80000">
                        <a:schemeClr val="phClr">
                          <a:shade val="93000"/>
                          <a:satMod val="130000"/>
                        </a:schemeClr>
                      </a:gs>
                      <a:gs pos="100000">
                        <a:schemeClr val="phClr">
                          <a:shade val="94000"/>
                          <a:satMod val="135000"/>
                        </a:schemeClr>
                      </a:gs>
                    </a:gsLst>
                    <a:lin ang="16200000" scaled="0"/>
                  </a:gradFill>
                </a:fillStyleLst>
                <a:lnStyleLst>
                  <a:ln w="9525" cap="flat" cmpd="sng" algn="ctr">
                    <a:solidFill>
                      <a:schemeClr val="phClr">
                        <a:shade val="95000"/>
                        <a:satMod val="105000"/>
                      </a:schemeClr>
                    </a:solidFill>
                    <a:prstDash val="solid"/>
                  </a:ln>
                  <a:ln w="25400" cap="flat" cmpd="sng" algn="ctr">
                    <a:solidFill>
                      <a:schemeClr val="phClr"/>
                    </a:solidFill>
                    <a:prstDash val="solid"/>
                  </a:ln>
                  <a:ln w="38100" cap="flat" cmpd="sng" algn="ctr">
                    <a:solidFill>
                      <a:schemeClr val="phClr"/>
                    </a:solidFill>
                    <a:prstDash val="solid"/>
                  </a:ln>
                </a:lnStyleLst>
                <a:effectStyleLst>
                  <a:effectStyle>
                    <a:effectLst>
                      <a:outerShdw blurRad="40000" dist="20000" dir="5400000" rotWithShape="0">
                        <a:srgbClr val="000000">
                          <a:alpha val="38000"/>
                        </a:srgbClr>
                      </a:outerShdw>
                    </a:effectLst>
                  </a:effectStyle>
                  <a:effectStyle>
                    <a:effectLst>
                      <a:outerShdw blurRad="40000" dist="23000" dir="5400000" rotWithShape="0">
                        <a:srgbClr val="000000">
                          <a:alpha val="35000"/>
                        </a:srgbClr>
                      </a:outerShdw>
                    </a:effectLst>
                  </a:effectStyle>
                  <a:effectStyle>
                    <a:effectLst>
                      <a:outerShdw blurRad="40000" dist="23000" dir="5400000" rotWithShape="0">
                        <a:srgbClr val="000000">
                          <a:alpha val="35000"/>
                        </a:srgbClr>
                      </a:outerShdw>
                    </a:effectLst>
                    <a:scene3d>
                      <a:camera prst="orthographicFront">
                        <a:rot lat="0" lon="0" rev="0"/>
                      </a:camera>
                      <a:lightRig rig="threePt" dir="t">
                        <a:rot lat="0" lon="0" rev="1200000"/>
                      </a:lightRig>
                    </a:scene3d>
                    <a:sp3d>
                      <a:bevelT w="63500" h="25400"/>
                    </a:sp3d>
                  </a:effectStyle>
                </a:effectStyleLst>
                <a:bgFillStyleLst>
                  <a:solidFill>
                    <a:schemeClr val="phClr"/>
                  </a:solidFill>
                  <a:gradFill rotWithShape="1">
                    <a:gsLst>
                      <a:gs pos="0">
                        <a:schemeClr val="phClr">
                          <a:tint val="40000"/>
                          <a:satMod val="350000"/>
                        </a:schemeClr>
                      </a:gs>
                      <a:gs pos="40000">
                        <a:schemeClr val="phClr">
                          <a:tint val="45000"/>
                          <a:shade val="99000"/>
                          <a:satMod val="350000"/>
                        </a:schemeClr>
                      </a:gs>
                      <a:gs pos="100000">
                        <a:schemeClr val="phClr">
                          <a:shade val="20000"/>
                          <a:satMod val="255000"/>
                        </a:schemeClr>
                      </a:gs>
                    </a:gsLst>
                    <a:path path="circle">
                      <a:fillToRect l="50000" t="-80000" r="50000" b="180000"/>
                    </a:path>
                  </a:gradFill>
                  <a:gradFill rotWithShape="1">
                    <a:gsLst>
                      <a:gs pos="0">
                        <a:schemeClr val="phClr">
                          <a:tint val="80000"/>
                          <a:satMod val="300000"/>
                        </a:schemeClr>
                      </a:gs>
                      <a:gs pos="100000">
                        <a:schemeClr val="phClr">
                          <a:shade val="30000"/>
                          <a:satMod val="200000"/>
                        </a:schemeClr>
                      </a:gs>
                    </a:gsLst>
                    <a:path path="circle">
                      <a:fillToRect l="50000" t="50000" r="50000" b="50000"/>
                    </a:path>
                  </a:gradFill>
                </a:bgFillStyleLst>
              </a:fmtScheme>
            </a:themeElements>
            <a:objectDefaults/>
            <a:extraClrSchemeLst/>
          </a:theme>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/settings.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml">
        <pkg:xmlData>
          <w:settings mc:Ignorable="w14" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:sl="http://schemas.openxmlformats.org/schemaLibrary/2006/main">
            <w:zoom w:percent="100"/>
            <w:proofState w:spelling="clean" w:grammar="clean"/>
            <w:defaultTabStop w:val="720"/>
            <w:characterSpacingControl w:val="doNotCompress"/>
            <w:footnotePr>
              <w:footnote w:id="-1"/>
              <w:footnote w:id="0"/>
            </w:footnotePr>
            <w:endnotePr>
              <w:endnote w:id="-1"/>
              <w:endnote w:id="0"/>
            </w:endnotePr>
            <w:compat>
              <w:compatSetting w:name="compatibilityMode" w:uri="http://schemas.microsoft.com/office/word" w:val="14"/>
              <w:compatSetting w:name="overrideTableStyleFontSizeAndJustification" w:uri="http://schemas.microsoft.com/office/word" w:val="1"/>
              <w:compatSetting w:name="enableOpenTypeFeatures" w:uri="http://schemas.microsoft.com/office/word" w:val="1"/>
              <w:compatSetting w:name="doNotFlipMirrorIndents" w:uri="http://schemas.microsoft.com/office/word" w:val="1"/>
            </w:compat>
            <w:rsids>
              <w:rsidRoot w:val="00DD7F7E"/>
              <w:rsid w:val="00015445"/>
              <w:rsid w:val="000B37CF"/>
              <w:rsid w:val="002A6754"/>
              <w:rsid w:val="003F0FA1"/>
              <w:rsid w:val="005777CF"/>
              <w:rsid w:val="005A004A"/>
              <w:rsid w:val="007D4DF3"/>
              <w:rsid w:val="00840B71"/>
              <w:rsid w:val="008A4629"/>
              <w:rsid w:val="009E2D5F"/>
              <w:rsid w:val="00A250A6"/>
              <w:rsid w:val="00B46962"/>
              <w:rsid w:val="00C63E00"/>
              <w:rsid w:val="00D71896"/>
              <w:rsid w:val="00D912F0"/>
              <w:rsid w:val="00DD7F7E"/>
            </w:rsids>
            <m:mathPr>
              <m:mathFont m:val="Cambria Math"/>
              <m:brkBin m:val="before"/>
              <m:brkBinSub m:val="--"/>
              <m:smallFrac m:val="0"/>
              <m:dispDef/>
              <m:lMargin m:val="0"/>
              <m:rMargin m:val="0"/>
              <m:defJc m:val="centerGroup"/>
              <m:wrapIndent m:val="1440"/>
              <m:intLim m:val="subSup"/>
              <m:naryLim m:val="undOvr"/>
            </m:mathPr>
            <w:themeFontLang w:val="en-US"/>
            <w:clrSchemeMapping w:bg1="light1" w:t1="dark1" w:bg2="light2" w:t2="dark2" w:accent1="accent1" w:accent2="accent2" w:accent3="accent3" w:accent4="accent4" w:accent5="accent5" w:accent6="accent6" w:hyperlink="hyperlink" w:followedHyperlink="followedHyperlink"/>
            <w:shapeDefaults>
              <o:shapedefaults v:ext="edit" spidmax="1026"/>
              <o:shapelayout v:ext="edit">
                <o:idmap v:ext="edit" data="1"/>
              </o:shapelayout>
            </w:shapeDefaults>
            <w:decimalSymbol w:val="."/>
            <w:listSeparator w:val=","/>
          </w:settings>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/fontTable.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml">
        <pkg:xmlData>
          <w:fonts mc:Ignorable="w14" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml">
            <w:font w:name="Symbol">
              <w:panose1 w:val="05050102010706020507"/>
              <w:charset w:val="02"/>
              <w:family w:val="roman"/>
              <w:pitch w:val="variable"/>
              <w:sig w:usb0="00000000" w:usb1="10000000" w:usb2="00000000" w:usb3="00000000" w:csb0="80000000" w:csb1="00000000"/>
            </w:font>
            <w:font w:name="Times New Roman">
              <w:panose1 w:val="02020603050405020304"/>
              <w:charset w:val="00"/>
              <w:family w:val="roman"/>
              <w:pitch w:val="variable"/>
              <w:sig w:usb0="E0002AFF" w:usb1="C0007841" w:usb2="00000009" w:usb3="00000000" w:csb0="000001FF" w:csb1="00000000"/>
            </w:font>
            <w:font w:name="Courier New">
              <w:panose1 w:val="02070309020205020404"/>
              <w:charset w:val="00"/>
              <w:family w:val="modern"/>
              <w:pitch w:val="fixed"/>
              <w:sig w:usb0="E0002AFF" w:usb1="C0007843" w:usb2="00000009" w:usb3="00000000" w:csb0="000001FF" w:csb1="00000000"/>
            </w:font>
            <w:font w:name="Wingdings">
              <w:panose1 w:val="05000000000000000000"/>
              <w:charset w:val="02"/>
              <w:family w:val="auto"/>
              <w:pitch w:val="variable"/>
              <w:sig w:usb0="00000000" w:usb1="10000000" w:usb2="00000000" w:usb3="00000000" w:csb0="80000000" w:csb1="00000000"/>
            </w:font>
            <w:font w:name="Calibri">
              <w:panose1 w:val="020F0502020204030204"/>
              <w:charset w:val="00"/>
              <w:family w:val="swiss"/>
              <w:pitch w:val="variable"/>
              <w:sig w:usb0="E00002FF" w:usb1="4000ACFF" w:usb2="00000001" w:usb3="00000000" w:csb0="0000019F" w:csb1="00000000"/>
            </w:font>
            <w:font w:name="Cambria">
              <w:panose1 w:val="02040503050406030204"/>
              <w:charset w:val="00"/>
              <w:family w:val="roman"/>
              <w:pitch w:val="variable"/>
              <w:sig w:usb0="E00002FF" w:usb1="400004FF" w:usb2="00000000" w:usb3="00000000" w:csb0="0000019F" w:csb1="00000000"/>
            </w:font>
            <w:font w:name="Tahoma">
              <w:panose1 w:val="020B0604030504040204"/>
              <w:charset w:val="00"/>
              <w:family w:val="swiss"/>
              <w:notTrueType/>
              <w:pitch w:val="variable"/>
              <w:sig w:usb0="00000003" w:usb1="00000000" w:usb2="00000000" w:usb3="00000000" w:csb0="00000001" w:csb1="00000000"/>
            </w:font>
          </w:fonts>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/styles.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml">
        <pkg:xmlData>
          <w:styles mc:Ignorable="w14" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml">
            <w:docDefaults>
              <w:rPrDefault>
                <w:rPr>
                  <w:rFonts w:asciiTheme="minorHAnsi" w:eastAsiaTheme="minorHAnsi" w:hAnsiTheme="minorHAnsi" w:cstheme="minorBidi"/>
                  <w:sz w:val="22"/>
                  <w:szCs w:val="22"/>
                  <w:lang w:val="en-US" w:eastAsia="en-US" w:bidi="ar-SA"/>
                </w:rPr>
              </w:rPrDefault>
              <w:pPrDefault>
                <w:pPr>
                  <w:spacing w:after="200" w:line="276" w:lineRule="auto"/>
                </w:pPr>
              </w:pPrDefault>
            </w:docDefaults>
            <w:latentStyles w:defLockedState="0" w:defUIPriority="99" w:defSemiHidden="1" w:defUnhideWhenUsed="1" w:defQFormat="0" w:count="267">
              <w:lsdException w:name="Normal" w:semiHidden="0" w:uiPriority="0" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="heading 1" w:semiHidden="0" w:uiPriority="9" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="heading 2" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 3" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 4" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 5" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 6" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 7" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 8" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 9" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="toc 1" w:uiPriority="39"/>
              <w:lsdException w:name="toc 2" w:uiPriority="39"/>
              <w:lsdException w:name="toc 3" w:uiPriority="39"/>
              <w:lsdException w:name="toc 4" w:uiPriority="39"/>
              <w:lsdException w:name="toc 5" w:uiPriority="39"/>
              <w:lsdException w:name="toc 6" w:uiPriority="39"/>
              <w:lsdException w:name="toc 7" w:uiPriority="39"/>
              <w:lsdException w:name="toc 8" w:uiPriority="39"/>
              <w:lsdException w:name="toc 9" w:uiPriority="39"/>
              <w:lsdException w:name="caption" w:uiPriority="35" w:qFormat="1"/>
              <w:lsdException w:name="Title" w:semiHidden="0" w:uiPriority="10" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Default Paragraph Font" w:uiPriority="1"/>
              <w:lsdException w:name="Subtitle" w:semiHidden="0" w:uiPriority="11" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Strong" w:semiHidden="0" w:uiPriority="22" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Emphasis" w:semiHidden="0" w:uiPriority="20" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Table Grid" w:semiHidden="0" w:uiPriority="59" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Placeholder Text" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="No Spacing" w:semiHidden="0" w:uiPriority="1" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Light Shading" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 1" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 1" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 1" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 1" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 1" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 1" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Revision" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="List Paragraph" w:semiHidden="0" w:uiPriority="34" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Quote" w:semiHidden="0" w:uiPriority="29" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Intense Quote" w:semiHidden="0" w:uiPriority="30" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Medium List 2 Accent 1" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 1" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 1" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 1" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 1" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 1" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 1" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 1" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 2" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 2" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 2" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 2" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 2" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 2" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 2" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 2" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 2" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 2" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 2" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 2" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 2" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 2" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 3" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 3" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 3" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 3" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 3" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 3" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 3" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 3" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 3" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 3" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 3" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 3" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 3" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 3" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 4" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 4" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 4" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 4" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 4" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 4" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 4" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 4" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 4" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 4" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 4" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 4" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 4" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 4" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 5" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 5" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 5" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 5" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 5" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 5" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 5" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 5" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 5" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 5" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 5" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 5" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 5" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 5" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 6" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 6" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 6" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 6" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 6" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 6" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 6" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 6" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 6" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 6" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 6" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 6" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 6" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 6" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Subtle Emphasis" w:semiHidden="0" w:uiPriority="19" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Intense Emphasis" w:semiHidden="0" w:uiPriority="21" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Subtle Reference" w:semiHidden="0" w:uiPriority="31" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Intense Reference" w:semiHidden="0" w:uiPriority="32" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Book Title" w:semiHidden="0" w:uiPriority="33" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Bibliography" w:uiPriority="37"/>
              <w:lsdException w:name="TOC Heading" w:uiPriority="39" w:qFormat="1"/>
            </w:latentStyles>
            <w:style w:type="paragraph" w:default="1" w:styleId="Normal">
              <w:name w:val="Normal"/>
              <w:qFormat/>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Heading1">
              <w:name w:val="heading 1"/>
              <w:basedOn w:val="Normal"/>
              <w:next w:val="Normal"/>
              <w:link w:val="Heading1Char"/>
              <w:uiPriority w:val="9"/>
              <w:qFormat/>
              <w:rsid w:val="00113342"/>
              <w:pPr>
                <w:keepNext/>
                <w:keepLines/>
                <w:spacing w:before="240" w:after="0" w:line="240" w:lineRule="auto"/>
                <w:outlineLvl w:val="0"/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="365F91" w:themeColor="accent1" w:themeShade="BF"/>
                <w:sz w:val="28"/>
                <w:szCs w:val="28"/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Heading2">
              <w:name w:val="heading 2"/>
              <w:basedOn w:val="Normal"/>
              <w:next w:val="Normal"/>
              <w:link w:val="Heading2Char"/>
              <w:uiPriority w:val="9"/>
              <w:unhideWhenUsed/>
              <w:qFormat/>
              <w:rsid w:val="00D912F0"/>
              <w:pPr>
                <w:keepNext/>
                <w:keepLines/>
                <w:spacing w:before="200" w:after="0"/>
                <w:outlineLvl w:val="1"/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="4F81BD" w:themeColor="accent1"/>
                <w:sz w:val="26"/>
                <w:szCs w:val="26"/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Heading3">
              <w:name w:val="heading 3"/>
              <w:basedOn w:val="Normal"/>
              <w:next w:val="Normal"/>
              <w:link w:val="Heading3Char"/>
              <w:uiPriority w:val="9"/>
              <w:unhideWhenUsed/>
              <w:qFormat/>
              <w:rsid w:val="000B37CF"/>
              <w:pPr>
                <w:keepNext/>
                <w:keepLines/>
                <w:spacing w:before="200" w:after="0"/>
                <w:outlineLvl w:val="2"/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="4F81BD" w:themeColor="accent1"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:default="1" w:styleId="DefaultParagraphFont">
              <w:name w:val="Default Paragraph Font"/>
              <w:uiPriority w:val="1"/>
              <w:semiHidden/>
              <w:unhideWhenUsed/>
            </w:style>
            <w:style w:type="table" w:default="1" w:styleId="TableNormal">
              <w:name w:val="Normal Table"/>
              <w:uiPriority w:val="99"/>
              <w:semiHidden/>
              <w:unhideWhenUsed/>
              <w:tblPr>
                <w:tblInd w:w="0" w:type="dxa"/>
                <w:tblCellMar>
                  <w:top w:w="0" w:type="dxa"/>
                  <w:left w:w="108" w:type="dxa"/>
                  <w:bottom w:w="0" w:type="dxa"/>
                  <w:right w:w="108" w:type="dxa"/>
                </w:tblCellMar>
              </w:tblPr>
            </w:style>
            <w:style w:type="numbering" w:default="1" w:styleId="NoList">
              <w:name w:val="No List"/>
              <w:uiPriority w:val="99"/>
              <w:semiHidden/>
              <w:unhideWhenUsed/>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Header">
              <w:name w:val="header"/>
              <w:basedOn w:val="Normal"/>
              <w:link w:val="HeaderChar"/>
              <w:uiPriority w:val="99"/>
              <w:unhideWhenUsed/>
              <w:rsid w:val="00DD7F7E"/>
              <w:pPr>
                <w:tabs>
                  <w:tab w:val="center" w:pos="4680"/>
                  <w:tab w:val="right" w:pos="9360"/>
                </w:tabs>
                <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
              </w:pPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="HeaderChar">
              <w:name w:val="Header Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Header"/>
              <w:uiPriority w:val="99"/>
              <w:rsid w:val="00DD7F7E"/>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Footer">
              <w:name w:val="footer"/>
              <w:basedOn w:val="Normal"/>
              <w:link w:val="FooterChar"/>
              <w:uiPriority w:val="99"/>
              <w:unhideWhenUsed/>
              <w:rsid w:val="00DD7F7E"/>
              <w:pPr>
                <w:tabs>
                  <w:tab w:val="center" w:pos="4680"/>
                  <w:tab w:val="right" w:pos="9360"/>
                </w:tabs>
                <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
              </w:pPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="FooterChar">
              <w:name w:val="Footer Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Footer"/>
              <w:uiPriority w:val="99"/>
              <w:rsid w:val="00DD7F7E"/>
            </w:style>
            <w:style w:type="paragraph" w:styleId="ListParagraph">
              <w:name w:val="List Paragraph"/>
              <w:basedOn w:val="Normal"/>
              <w:uiPriority w:val="34"/>
              <w:qFormat/>
              <w:rsid w:val="00D912F0"/>
              <w:pPr>
                <w:ind w:left="720"/>
                <w:contextualSpacing/>
              </w:pPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="Heading1Char">
              <w:name w:val="Heading 1 Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Heading1"/>
              <w:uiPriority w:val="9"/>
              <w:rsid w:val="00D912F0"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="365F91" w:themeColor="accent1" w:themeShade="BF"/>
                <w:sz w:val="28"/>
                <w:szCs w:val="28"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="Heading2Char">
              <w:name w:val="Heading 2 Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Heading2"/>
              <w:uiPriority w:val="9"/>
              <w:rsid w:val="00D912F0"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="4F81BD" w:themeColor="accent1"/>
                <w:sz w:val="26"/>
                <w:szCs w:val="26"/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:styleId="BalloonText">
              <w:name w:val="Balloon Text"/>
              <w:basedOn w:val="Normal"/>
              <w:link w:val="BalloonTextChar"/>
              <w:uiPriority w:val="99"/>
              <w:semiHidden/>
              <w:unhideWhenUsed/>
              <w:rsid w:val="009E2D5F"/>
              <w:pPr>
                <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:ascii="Tahoma" w:hAnsi="Tahoma" w:cs="Tahoma"/>
                <w:sz w:val="16"/>
                <w:szCs w:val="16"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="BalloonTextChar">
              <w:name w:val="Balloon Text Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="BalloonText"/>
              <w:uiPriority w:val="99"/>
              <w:semiHidden/>
              <w:rsid w:val="009E2D5F"/>
              <w:rPr>
                <w:rFonts w:ascii="Tahoma" w:hAnsi="Tahoma" w:cs="Tahoma"/>
                <w:sz w:val="16"/>
                <w:szCs w:val="16"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="Heading3Char">
              <w:name w:val="Heading 3 Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Heading3"/>
              <w:uiPriority w:val="9"/>
              <w:rsid w:val="000B37CF"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="4F81BD" w:themeColor="accent1"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="JobDates">
              <w:name w:val="JobDates"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:uiPriority w:val="1"/>
              <w:qFormat/>
              <w:rsid w:val="000B37CF"/>
              <w:rPr>
                <w:i/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Title">
              <w:name w:val="Title"/>
              <w:basedOn w:val="Normal"/>
              <w:next w:val="Normal"/>
              <w:link w:val="TitleChar"/>
              <w:uiPriority w:val="10"/>
              <w:qFormat/>
              <w:rsid w:val="005777CF"/>
              <w:pPr>
                <w:pBdr>
                  <w:bottom w:val="single" w:sz="8" w:space="4" w:color="4F81BD" w:themeColor="accent1"/>
                </w:pBdr>
                <w:spacing w:after="300" w:line="240" w:lineRule="auto"/>
                <w:contextualSpacing/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:color w:val="17365D" w:themeColor="text2" w:themeShade="BF"/>
                <w:spacing w:val="5"/>
                <w:kern w:val="28"/>
                <w:sz w:val="52"/>
                <w:szCs w:val="52"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="TitleChar">
              <w:name w:val="Title Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Title"/>
              <w:uiPriority w:val="10"/>
              <w:rsid w:val="005777CF"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:color w:val="17365D" w:themeColor="text2" w:themeShade="BF"/>
                <w:spacing w:val="5"/>
                <w:kern w:val="28"/>
                <w:sz w:val="52"/>
                <w:szCs w:val="52"/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:customStyle="1" w:styleId="HeaderTitle">
              <w:name w:val="Header Title"/>
              <w:basedOn w:val="Title"/>
              <w:link w:val="HeaderTitleChar"/>
              <w:qFormat/>
              <w:rsid w:val="005777CF"/>
              <w:pPr>
                <w:spacing w:after="120"/>
              </w:pPr>
            </w:style>
            <w:style w:type="paragraph" w:customStyle="1" w:styleId="HeaderText1">
              <w:name w:val="Header Text 1"/>
              <w:basedOn w:val="Header"/>
              <w:link w:val="HeaderText1Char"/>
              <w:qFormat/>
              <w:rsid w:val="005777CF"/>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="HeaderTitleChar">
              <w:name w:val="Header Title Char"/>
              <w:basedOn w:val="TitleChar"/>
              <w:link w:val="HeaderTitle"/>
              <w:rsid w:val="005777CF"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:color w:val="17365D" w:themeColor="text2" w:themeShade="BF"/>
                <w:spacing w:val="5"/>
                <w:kern w:val="28"/>
                <w:sz w:val="52"/>
                <w:szCs w:val="52"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="HeaderText1Char">
              <w:name w:val="Header Text 1 Char"/>
              <w:basedOn w:val="HeaderChar"/>
              <w:link w:val="HeaderText1"/>
              <w:rsid w:val="005777CF"/>
            </w:style>
            <w:style w:type="paragraph" w:customStyle="1" w:styleId="TagLine">
              <w:name w:val="TagLine"/>
              <w:basedOn w:val="Normal"/>
              <w:link w:val="TagLineChar"/>
              <w:qFormat/>
              <w:rsid w:val="003C1EAC"/>
              <w:pPr>
                <w:jc w:val="center"/>
              </w:pPr>
              <w:rPr>
                <w:i/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="TagLineChar">
              <w:name w:val="TagLine Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="TagLine"/>
              <w:rsid w:val="003C1EAC"/>
              <w:rPr>
                <w:i/>
              </w:rPr>
            </w:style>
          </w:styles>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/stylesWithEffects.xml" pkg:contentType="application/vnd.ms-word.stylesWithEffects+xml">
        <pkg:xmlData>
          <w:styles mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:docDefaults>
              <w:rPrDefault>
                <w:rPr>
                  <w:rFonts w:asciiTheme="minorHAnsi" w:eastAsiaTheme="minorHAnsi" w:hAnsiTheme="minorHAnsi" w:cstheme="minorBidi"/>
                  <w:sz w:val="22"/>
                  <w:szCs w:val="22"/>
                  <w:lang w:val="en-US" w:eastAsia="en-US" w:bidi="ar-SA"/>
                </w:rPr>
              </w:rPrDefault>
              <w:pPrDefault>
                <w:pPr>
                  <w:spacing w:after="200" w:line="276" w:lineRule="auto"/>
                </w:pPr>
              </w:pPrDefault>
            </w:docDefaults>
            <w:latentStyles w:defLockedState="0" w:defUIPriority="99" w:defSemiHidden="1" w:defUnhideWhenUsed="1" w:defQFormat="0" w:count="267">
              <w:lsdException w:name="Normal" w:semiHidden="0" w:uiPriority="0" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="heading 1" w:semiHidden="0" w:uiPriority="9" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="heading 2" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 3" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 4" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 5" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 6" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 7" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 8" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="heading 9" w:uiPriority="9" w:qFormat="1"/>
              <w:lsdException w:name="toc 1" w:uiPriority="39"/>
              <w:lsdException w:name="toc 2" w:uiPriority="39"/>
              <w:lsdException w:name="toc 3" w:uiPriority="39"/>
              <w:lsdException w:name="toc 4" w:uiPriority="39"/>
              <w:lsdException w:name="toc 5" w:uiPriority="39"/>
              <w:lsdException w:name="toc 6" w:uiPriority="39"/>
              <w:lsdException w:name="toc 7" w:uiPriority="39"/>
              <w:lsdException w:name="toc 8" w:uiPriority="39"/>
              <w:lsdException w:name="toc 9" w:uiPriority="39"/>
              <w:lsdException w:name="caption" w:uiPriority="35" w:qFormat="1"/>
              <w:lsdException w:name="Title" w:semiHidden="0" w:uiPriority="10" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Default Paragraph Font" w:uiPriority="1"/>
              <w:lsdException w:name="Subtitle" w:semiHidden="0" w:uiPriority="11" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Strong" w:semiHidden="0" w:uiPriority="22" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Emphasis" w:semiHidden="0" w:uiPriority="20" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Table Grid" w:semiHidden="0" w:uiPriority="59" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Placeholder Text" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="No Spacing" w:semiHidden="0" w:uiPriority="1" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Light Shading" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 1" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 1" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 1" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 1" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 1" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 1" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Revision" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="List Paragraph" w:semiHidden="0" w:uiPriority="34" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Quote" w:semiHidden="0" w:uiPriority="29" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Intense Quote" w:semiHidden="0" w:uiPriority="30" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Medium List 2 Accent 1" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 1" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 1" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 1" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 1" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 1" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 1" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 1" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 2" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 2" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 2" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 2" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 2" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 2" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 2" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 2" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 2" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 2" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 2" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 2" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 2" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 2" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 3" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 3" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 3" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 3" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 3" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 3" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 3" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 3" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 3" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 3" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 3" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 3" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 3" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 3" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 4" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 4" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 4" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 4" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 4" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 4" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 4" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 4" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 4" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 4" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 4" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 4" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 4" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 4" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 5" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 5" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 5" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 5" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 5" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 5" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 5" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 5" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 5" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 5" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 5" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 5" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 5" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 5" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Shading Accent 6" w:semiHidden="0" w:uiPriority="60" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light List Accent 6" w:semiHidden="0" w:uiPriority="61" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Light Grid Accent 6" w:semiHidden="0" w:uiPriority="62" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 1 Accent 6" w:semiHidden="0" w:uiPriority="63" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Shading 2 Accent 6" w:semiHidden="0" w:uiPriority="64" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 1 Accent 6" w:semiHidden="0" w:uiPriority="65" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium List 2 Accent 6" w:semiHidden="0" w:uiPriority="66" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 1 Accent 6" w:semiHidden="0" w:uiPriority="67" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 2 Accent 6" w:semiHidden="0" w:uiPriority="68" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Medium Grid 3 Accent 6" w:semiHidden="0" w:uiPriority="69" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Dark List Accent 6" w:semiHidden="0" w:uiPriority="70" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Shading Accent 6" w:semiHidden="0" w:uiPriority="71" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful List Accent 6" w:semiHidden="0" w:uiPriority="72" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Colorful Grid Accent 6" w:semiHidden="0" w:uiPriority="73" w:unhideWhenUsed="0"/>
              <w:lsdException w:name="Subtle Emphasis" w:semiHidden="0" w:uiPriority="19" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Intense Emphasis" w:semiHidden="0" w:uiPriority="21" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Subtle Reference" w:semiHidden="0" w:uiPriority="31" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Intense Reference" w:semiHidden="0" w:uiPriority="32" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Book Title" w:semiHidden="0" w:uiPriority="33" w:unhideWhenUsed="0" w:qFormat="1"/>
              <w:lsdException w:name="Bibliography" w:uiPriority="37"/>
              <w:lsdException w:name="TOC Heading" w:uiPriority="39" w:qFormat="1"/>
            </w:latentStyles>
            <w:style w:type="paragraph" w:default="1" w:styleId="Normal">
              <w:name w:val="Normal"/>
              <w:qFormat/>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Heading1">
              <w:name w:val="heading 1"/>
              <w:basedOn w:val="Normal"/>
              <w:next w:val="Normal"/>
              <w:link w:val="Heading1Char"/>
              <w:uiPriority w:val="9"/>
              <w:qFormat/>
              <w:rsid w:val="00D912F0"/>
              <w:pPr>
                <w:keepNext/>
                <w:keepLines/>
                <w:spacing w:before="480" w:after="0"/>
                <w:outlineLvl w:val="0"/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="365F91" w:themeColor="accent1" w:themeShade="BF"/>
                <w:sz w:val="28"/>
                <w:szCs w:val="28"/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Heading2">
              <w:name w:val="heading 2"/>
              <w:basedOn w:val="Normal"/>
              <w:next w:val="Normal"/>
              <w:link w:val="Heading2Char"/>
              <w:uiPriority w:val="9"/>
              <w:unhideWhenUsed/>
              <w:qFormat/>
              <w:rsid w:val="00D912F0"/>
              <w:pPr>
                <w:keepNext/>
                <w:keepLines/>
                <w:spacing w:before="200" w:after="0"/>
                <w:outlineLvl w:val="1"/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="4F81BD" w:themeColor="accent1"/>
                <w:sz w:val="26"/>
                <w:szCs w:val="26"/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Heading3">
              <w:name w:val="heading 3"/>
              <w:basedOn w:val="Normal"/>
              <w:next w:val="Normal"/>
              <w:link w:val="Heading3Char"/>
              <w:uiPriority w:val="9"/>
              <w:unhideWhenUsed/>
              <w:qFormat/>
              <w:rsid w:val="000B37CF"/>
              <w:pPr>
                <w:keepNext/>
                <w:keepLines/>
                <w:spacing w:before="200" w:after="0"/>
                <w:outlineLvl w:val="2"/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="4F81BD" w:themeColor="accent1"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:default="1" w:styleId="DefaultParagraphFont">
              <w:name w:val="Default Paragraph Font"/>
              <w:uiPriority w:val="1"/>
              <w:semiHidden/>
              <w:unhideWhenUsed/>
            </w:style>
            <w:style w:type="table" w:default="1" w:styleId="TableNormal">
              <w:name w:val="Normal Table"/>
              <w:uiPriority w:val="99"/>
              <w:semiHidden/>
              <w:unhideWhenUsed/>
              <w:tblPr>
                <w:tblInd w:w="0" w:type="dxa"/>
                <w:tblCellMar>
                  <w:top w:w="0" w:type="dxa"/>
                  <w:left w:w="108" w:type="dxa"/>
                  <w:bottom w:w="0" w:type="dxa"/>
                  <w:right w:w="108" w:type="dxa"/>
                </w:tblCellMar>
              </w:tblPr>
            </w:style>
            <w:style w:type="numbering" w:default="1" w:styleId="NoList">
              <w:name w:val="No List"/>
              <w:uiPriority w:val="99"/>
              <w:semiHidden/>
              <w:unhideWhenUsed/>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Header">
              <w:name w:val="header"/>
              <w:basedOn w:val="Normal"/>
              <w:link w:val="HeaderChar"/>
              <w:uiPriority w:val="99"/>
              <w:unhideWhenUsed/>
              <w:rsid w:val="00DD7F7E"/>
              <w:pPr>
                <w:tabs>
                  <w:tab w:val="center" w:pos="4680"/>
                  <w:tab w:val="right" w:pos="9360"/>
                </w:tabs>
                <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
              </w:pPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="HeaderChar">
              <w:name w:val="Header Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Header"/>
              <w:uiPriority w:val="99"/>
              <w:rsid w:val="00DD7F7E"/>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Footer">
              <w:name w:val="footer"/>
              <w:basedOn w:val="Normal"/>
              <w:link w:val="FooterChar"/>
              <w:uiPriority w:val="99"/>
              <w:unhideWhenUsed/>
              <w:rsid w:val="00DD7F7E"/>
              <w:pPr>
                <w:tabs>
                  <w:tab w:val="center" w:pos="4680"/>
                  <w:tab w:val="right" w:pos="9360"/>
                </w:tabs>
                <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
              </w:pPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="FooterChar">
              <w:name w:val="Footer Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Footer"/>
              <w:uiPriority w:val="99"/>
              <w:rsid w:val="00DD7F7E"/>
            </w:style>
            <w:style w:type="paragraph" w:styleId="ListParagraph">
              <w:name w:val="List Paragraph"/>
              <w:basedOn w:val="Normal"/>
              <w:uiPriority w:val="34"/>
              <w:qFormat/>
              <w:rsid w:val="00D912F0"/>
              <w:pPr>
                <w:ind w:left="720"/>
                <w:contextualSpacing/>
              </w:pPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="Heading1Char">
              <w:name w:val="Heading 1 Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Heading1"/>
              <w:uiPriority w:val="9"/>
              <w:rsid w:val="00D912F0"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="365F91" w:themeColor="accent1" w:themeShade="BF"/>
                <w:sz w:val="28"/>
                <w:szCs w:val="28"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="Heading2Char">
              <w:name w:val="Heading 2 Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Heading2"/>
              <w:uiPriority w:val="9"/>
              <w:rsid w:val="00D912F0"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="4F81BD" w:themeColor="accent1"/>
                <w:sz w:val="26"/>
                <w:szCs w:val="26"/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:styleId="BalloonText">
              <w:name w:val="Balloon Text"/>
              <w:basedOn w:val="Normal"/>
              <w:link w:val="BalloonTextChar"/>
              <w:uiPriority w:val="99"/>
              <w:semiHidden/>
              <w:unhideWhenUsed/>
              <w:rsid w:val="009E2D5F"/>
              <w:pPr>
                <w:spacing w:after="0" w:line="240" w:lineRule="auto"/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:ascii="Tahoma" w:hAnsi="Tahoma" w:cs="Tahoma"/>
                <w:sz w:val="16"/>
                <w:szCs w:val="16"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="BalloonTextChar">
              <w:name w:val="Balloon Text Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="BalloonText"/>
              <w:uiPriority w:val="99"/>
              <w:semiHidden/>
              <w:rsid w:val="009E2D5F"/>
              <w:rPr>
                <w:rFonts w:ascii="Tahoma" w:hAnsi="Tahoma" w:cs="Tahoma"/>
                <w:sz w:val="16"/>
                <w:szCs w:val="16"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="Heading3Char">
              <w:name w:val="Heading 3 Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Heading3"/>
              <w:uiPriority w:val="9"/>
              <w:rsid w:val="000B37CF"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:b/>
                <w:bCs/>
                <w:color w:val="4F81BD" w:themeColor="accent1"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="JobDates">
              <w:name w:val="JobDates"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:uiPriority w:val="1"/>
              <w:qFormat/>
              <w:rsid w:val="000B37CF"/>
              <w:rPr>
                <w:i/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:styleId="Title">
              <w:name w:val="Title"/>
              <w:basedOn w:val="Normal"/>
              <w:next w:val="Normal"/>
              <w:link w:val="TitleChar"/>
              <w:uiPriority w:val="10"/>
              <w:qFormat/>
              <w:rsid w:val="005777CF"/>
              <w:pPr>
                <w:pBdr>
                  <w:bottom w:val="single" w:sz="8" w:space="4" w:color="4F81BD" w:themeColor="accent1"/>
                </w:pBdr>
                <w:spacing w:after="300" w:line="240" w:lineRule="auto"/>
                <w:contextualSpacing/>
              </w:pPr>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:color w:val="17365D" w:themeColor="text2" w:themeShade="BF"/>
                <w:spacing w:val="5"/>
                <w:kern w:val="28"/>
                <w:sz w:val="52"/>
                <w:szCs w:val="52"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="TitleChar">
              <w:name w:val="Title Char"/>
              <w:basedOn w:val="DefaultParagraphFont"/>
              <w:link w:val="Title"/>
              <w:uiPriority w:val="10"/>
              <w:rsid w:val="005777CF"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:color w:val="17365D" w:themeColor="text2" w:themeShade="BF"/>
                <w:spacing w:val="5"/>
                <w:kern w:val="28"/>
                <w:sz w:val="52"/>
                <w:szCs w:val="52"/>
              </w:rPr>
            </w:style>
            <w:style w:type="paragraph" w:customStyle="1" w:styleId="HeaderTitle">
              <w:name w:val="Header Title"/>
              <w:basedOn w:val="Title"/>
              <w:link w:val="HeaderTitleChar"/>
              <w:qFormat/>
              <w:rsid w:val="005777CF"/>
              <w:pPr>
                <w:spacing w:after="120"/>
              </w:pPr>
            </w:style>
            <w:style w:type="paragraph" w:customStyle="1" w:styleId="HeaderText1">
              <w:name w:val="Header Text 1"/>
              <w:basedOn w:val="Header"/>
              <w:link w:val="HeaderText1Char"/>
              <w:qFormat/>
              <w:rsid w:val="005777CF"/>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="HeaderTitleChar">
              <w:name w:val="Header Title Char"/>
              <w:basedOn w:val="TitleChar"/>
              <w:link w:val="HeaderTitle"/>
              <w:rsid w:val="005777CF"/>
              <w:rPr>
                <w:rFonts w:asciiTheme="majorHAnsi" w:eastAsiaTheme="majorEastAsia" w:hAnsiTheme="majorHAnsi" w:cstheme="majorBidi"/>
                <w:color w:val="17365D" w:themeColor="text2" w:themeShade="BF"/>
                <w:spacing w:val="5"/>
                <w:kern w:val="28"/>
                <w:sz w:val="52"/>
                <w:szCs w:val="52"/>
              </w:rPr>
            </w:style>
            <w:style w:type="character" w:customStyle="1" w:styleId="HeaderText1Char">
              <w:name w:val="Header Text 1 Char"/>
              <w:basedOn w:val="HeaderChar"/>
              <w:link w:val="HeaderText1"/>
              <w:rsid w:val="005777CF"/>
            </w:style>
          </w:styles>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/docProps/app.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.extended-properties+xml" pkg:padding="256">
        <pkg:xmlData>
          <Properties xmlns="http://schemas.openxmlformats.org/officeDocument/2006/extended-properties" xmlns:vt="http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes">
            <Template>Normal.dotm</Template>
            <TotalTime>7</TotalTime>
            <Pages>1</Pages>
            <Words>45</Words>
            <Characters>263</Characters>
            <Application>Microsoft Office Word</Application>
            <DocSecurity>0</DocSecurity>
            <Lines>2</Lines>
            <Paragraphs>1</Paragraphs>
            <ScaleCrop>false</ScaleCrop>
            <HeadingPairs>
              <vt:vector size="2" baseType="variant">
                <vt:variant>
                  <vt:lpstr>Title</vt:lpstr>
                </vt:variant>
                <vt:variant>
                  <vt:i4>1</vt:i4>
                </vt:variant>
              </vt:vector>
            </HeadingPairs>
            <TitlesOfParts>
              <vt:vector size="1" baseType="lpstr">
                <vt:lpstr/>
              </vt:vector>
            </TitlesOfParts>
            <Company/>
            <LinksUpToDate>false</LinksUpToDate>
            <CharactersWithSpaces>307</CharactersWithSpaces>
            <SharedDoc>false</SharedDoc>
            <HyperlinksChanged>false</HyperlinksChanged>
            <AppVersion>14.0000</AppVersion>
          </Properties>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/docProps/core.xml" pkg:contentType="application/vnd.openxmlformats-package.core-properties+xml" pkg:padding="256">
        <pkg:xmlData>
          <cp:coreProperties xmlns:cp="http://schemas.openxmlformats.org/package/2006/metadata/core-properties"
                             xmlns:dc="http://purl.org/dc/elements/1.1/"
                             xmlns:dcterms="http://purl.org/dc/terms/"
                             xmlns:dcmitype="http://purl.org/dc/dcmitype/"
                             xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
            <dc:title>
              Resume of <xsl:value-of select="ResumeOutputModel/UserProfile/FirstName"/><xsl:text disable-output-escaping="yes"> </xsl:text><xsl:value-of select="ResumeOutputModel/UserProfile/LastName"/>
            </dc:title>
            <dc:creator>NuvolaResume.com</dc:creator>
            <cp:lastModifiedBy>NuvolaResume.com</cp:lastModifiedBy>
            <cp:revision>1</cp:revision>
            <dcterms:created xsi:type="dcterms:W3CDTF">
              <xsl:value-of select="ResumeOutputModel/Resume/DateEdited"/>
            </dcterms:created>
            <dcterms:modified xsi:type="dcterms:W3CDTF">
              <xsl:value-of select="ResumeOutputModel/Resume/DateEdited"/>
            </dcterms:modified>
          </cp:coreProperties>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/webSettings.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml">
        <pkg:xmlData>
          <w:webSettings mc:Ignorable="w14" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml">
            <w:optimizeForBrowser/>
            <w:allowPNG/>
          </w:webSettings>
        </pkg:xmlData>
      </pkg:part>
      <pkg:part pkg:name="/word/numbering.xml" pkg:contentType="application/vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml">
        <pkg:xmlData>
          <w:numbering mc:Ignorable="w14 wp14" xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" xmlns:w10="urn:schemas-microsoft-com:office:word" xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk" xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape">
            <w:abstractNum w:abstractNumId="0">
              <w:nsid w:val="71354012"/>
              <w:multiLevelType w:val="hybridMultilevel"/>
              <w:tmpl w:val="0CA6906E"/>
              <w:lvl w:ilvl="0" w:tplc="04090001">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val=""/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="720" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Symbol" w:hAnsi="Symbol" w:hint="default"/>
                </w:rPr>
              </w:lvl>
              <w:lvl w:ilvl="1" w:tplc="04090003" w:tentative="1">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val="o"/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="1440" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Courier New" w:hAnsi="Courier New" w:cs="Courier New" w:hint="default"/>
                </w:rPr>
              </w:lvl>
              <w:lvl w:ilvl="2" w:tplc="04090005" w:tentative="1">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val=""/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="2160" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Wingdings" w:hAnsi="Wingdings" w:hint="default"/>
                </w:rPr>
              </w:lvl>
              <w:lvl w:ilvl="3" w:tplc="04090001" w:tentative="1">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val=""/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="2880" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Symbol" w:hAnsi="Symbol" w:hint="default"/>
                </w:rPr>
              </w:lvl>
              <w:lvl w:ilvl="4" w:tplc="04090003" w:tentative="1">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val="o"/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="3600" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Courier New" w:hAnsi="Courier New" w:cs="Courier New" w:hint="default"/>
                </w:rPr>
              </w:lvl>
              <w:lvl w:ilvl="5" w:tplc="04090005" w:tentative="1">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val=""/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="4320" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Wingdings" w:hAnsi="Wingdings" w:hint="default"/>
                </w:rPr>
              </w:lvl>
              <w:lvl w:ilvl="6" w:tplc="04090001" w:tentative="1">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val=""/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="5040" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Symbol" w:hAnsi="Symbol" w:hint="default"/>
                </w:rPr>
              </w:lvl>
              <w:lvl w:ilvl="7" w:tplc="04090003" w:tentative="1">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val="o"/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="5760" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Courier New" w:hAnsi="Courier New" w:cs="Courier New" w:hint="default"/>
                </w:rPr>
              </w:lvl>
              <w:lvl w:ilvl="8" w:tplc="04090005" w:tentative="1">
                <w:start w:val="1"/>
                <w:numFmt w:val="bullet"/>
                <w:lvlText w:val=""/>
                <w:lvlJc w:val="left"/>
                <w:pPr>
                  <w:ind w:left="6480" w:hanging="360"/>
                </w:pPr>
                <w:rPr>
                  <w:rFonts w:ascii="Wingdings" w:hAnsi="Wingdings" w:hint="default"/>
                </w:rPr>
              </w:lvl>
            </w:abstractNum>
            <w:num w:numId="1">
              <w:abstractNumId w:val="0"/>
            </w:num>
          </w:numbering>
        </pkg:xmlData>
      </pkg:part>
    </pkg:package>
  </xsl:template>
  <xsl:template name="formatDate">
    <xsl:param name="dateTime" />
    <xsl:variable name="date" select="substring-before($dateTime, 'T')" />
    <xsl:variable name="year" select="substring-before($date, '-')" />
    <xsl:variable name="month" select="substring-before(substring-after($date, '-'), '-')" />
    <xsl:variable name="day" select="substring-after(substring-after($date, '-'), '-')" />
    <xsl:value-of select="concat($month, ',', $year)" />
  </xsl:template>
</xsl:stylesheet>