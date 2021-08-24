package com.jetbrains.rider.plugins.statiq

import com.intellij.codeInsight.template.TemplateActionContext
import com.intellij.codeInsight.template.TemplateContextType

class MarkdownContext protected constructor() : TemplateContextType("MARKDOWN", "Markdown") {
    @Override
    override fun isInContext(templateActionContext: TemplateActionContext): Boolean {
        return templateActionContext.file.name.endsWith(".md")

    }
}