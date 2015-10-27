<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:xs="http://www.w3.org/2001/XMLSchema"
      xmlns:ms="urn:schemas-microsoft-com:xslt"
      xmlns:dt="urn:schemas-microsoft-com:datatypes">

  <xsl:template match="/">
    <html>
      <head>
        <link src="./ResumeView.css"></link>
      </head>
      <body>
        <xsl:apply-templates/>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="Resume">
    <div class="resume_headregionwrap">
      <div class="resume_headerrow">
        <h2 class="resume">Resume of <xsl:value-of select="UserProfile/FullName"/></h2>
      </div>
      <div class="resumecolumn-2">
        e: <xsl:value-of select="UserProfile/EMailAddress1"/>
      </div>
      <div class="resumecolumn-2">
        e: <xsl:value-of select="UserProfile/EMailAddress2"/>
      </div>
      <div style="clear:both"></div>
      <div class="resumecolumn-3">
        t: <xsl:value-of select="UserProfile/PhoneNumber1"/>
      </div>
      <div class="resumecolumn-3">
        t: <xsl:value-of select="UserProfile/PhoneNumber2"/>
      </div>
      <div class="resumecolumn-3">
        t: <xsl:value-of select="UserProfile/PhoneNumber3"/>
      </div>
    </div>
    <p class="resumeheader_tagline">
      <xsl:value-of select="TagLine"/>
    </p>
    <h2 class="resume">Summary and Objectives</h2>
    <p>
      <xsl:value-of select="SummaryObjectives"/>
    </p>
    <!--<xsl:apply-templates select="SummaryObj"/>-->
    <xsl:apply-templates select="Achievements"/>
    <xsl:apply-templates select="Companies"/>
    <xsl:apply-templates select="VolunteerExperiences"/>
    <xsl:apply-templates select="UserSocialNetworks"/>


  </xsl:template>

  <!--<xsl:template match="SummaryObj">
  </xsl:template>-->
  
  <xsl:template match="Companies">
    <div id="Companies">
      <h2 class="resume">Career Experience</h2>
      <xsl:apply-templates>
        <xsl:sort select="DateEndTicks" data-type="number" order="descending"/>
        <xsl:sort select="Name" data-type="text"/>
        <xsl:sort select="DateStartTicks" data-type="number"/>

      </xsl:apply-templates>
    </div>
  </xsl:template>

  <xsl:template match="Company">

    <h3 class="resume">
      <!--<xsl:variable name="hyperlink"><xsl:value-of select="URL" /></xsl:variable>-->
      <xsl:apply-templates select="Name"/> - <xsl:apply-templates select="JobTitle"/>
      (<xsl:apply-templates select="DateStart"/> - <xsl:apply-templates select="DateEnd"/>)

    </h3>
    <xsl:if test="string-length(Summary) > 0">
      <p>
        <xsl:value-of select="Summary"/>
      </p>
    </xsl:if>
    <xsl:apply-templates select="Skills"/>
  </xsl:template>

  <xsl:template match="Company/Name">
    <xsl:variable name="hyperlink">
      <xsl:value-of select="../URL" />
    </xsl:variable>
    <xsl:choose>
      <xsl:when test="string-length($hyperlink) > 0">
        <a href="{$hyperlink}">
          <xsl:value-of select="."/>
        </a>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="."/>

      </xsl:otherwise>
    </xsl:choose>


  </xsl:template>

  <xsl:template name="JobTitle">
    <xsl:value-of select="JobTitle"/>
  </xsl:template>

  <xsl:template match="Company/DateStart">
    <xsl:choose>
      <xsl:when test="string-length(.) > 0">
        <xsl:value-of select="ms:format-date(., 'MMM, yyyy')" />
      </xsl:when>
      <xsl:otherwise>
      </xsl:otherwise>
    </xsl:choose>

  </xsl:template>

  <xsl:template match="Company/DateEnd">
    <xsl:choose>
      <xsl:when test="string-length(.) > 0">
        <xsl:value-of select="ms:format-date(., 'MMM, yyyy')" />
      </xsl:when>
      <xsl:otherwise>Present</xsl:otherwise>
    </xsl:choose>
  </xsl:template>

  <xsl:template match="Achievements">
    <h2 class="resume">Achievements</h2>
    <ul>
      <xsl:apply-templates/>
    </ul>
  </xsl:template>

  <xsl:template match="Achievement">
    <!--<td>
        <xsl:value-of select="ID"/>
      </td>-->
    <li>
      <xsl:value-of select="Name"/>
    </li>
  </xsl:template>
  <xsl:template match="Skills">
    <ul>
      <xsl:for-each select="Skill">
        <li>
          <xsl:value-of select="Description"/>
        </li>
      </xsl:for-each>
    </ul>
  </xsl:template>

  <xsl:template match="VolunteerExperiences">
    <h2 class="resume">Volunteer Experience</h2>
    <ul>
      <xsl:apply-templates/>
    </ul>
  </xsl:template>

  <xsl:template match="VolunteerExperience">
    <!--<td>
        <xsl:value-of select="ID"/>
      </td>-->
    <li>
      <b>
        <xsl:value-of select="Name"/>
      </b>
      <br/>
      <xsl:value-of select="Summary"/>
    </li>
  </xsl:template>

  <xsl:template match="UserSocialNetworks">
    <h2 class="resume">Social Networks</h2>
    <ul>
      <xsl:apply-templates/>
    </ul>
  </xsl:template>

  <xsl:template match="UserSocialNetwork">
    <li>
      <a href="{URL}">
        <xsl:value-of select="SocialNetwork/Name"/> - <xsl:value-of select="SocialNetworkAccount"/>
      </a>
    </li>
  </xsl:template>


</xsl:stylesheet>

