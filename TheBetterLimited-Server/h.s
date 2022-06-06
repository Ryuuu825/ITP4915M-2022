	.section	__TEXT,__text,regular,pure_instructions
	.build_version macos, 11, 0
	.p2align	2
__ZN4core3ops8function6FnOnce40call_once$u7b$$u7b$vtable.shim$u7d$$u7d$17h206b2bf18a36c8ceE:
	.cfi_startproc
	sub	sp, sp, #32
	stp	x29, x30, [sp, #16]
	add	x29, sp, #16
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	ldr	x0, [x0]
	bl	__ZN4core3ops8function6FnOnce9call_once17h3f39869e9adfb6ccE
	str	w0, [sp, #8]
	ldr	w0, [sp, #8]
	ldp	x29, x30, [sp, #16]
	add	sp, sp, #32
	ret
	.cfi_endproc

	.p2align	2
__ZN4core3ops8function6FnOnce9call_once17h17d09da0f6c5b02bE:
	.cfi_startproc
	sub	sp, sp, #32
	stp	x29, x30, [sp, #16]
	add	x29, sp, #16
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	blr	x0
	ldp	x29, x30, [sp, #16]
	add	sp, sp, #32
	ret
	.cfi_endproc

	.p2align	2
__ZN4core3ops8function6FnOnce9call_once17h3f39869e9adfb6ccE:
Lfunc_begin0:
	.cfi_startproc
	.cfi_personality 155, _rust_eh_personality
	.cfi_lsda 16, Lexception0
	sub	sp, sp, #64
	stp	x29, x30, [sp, #48]
	add	x29, sp, #48
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	mov	x8, x0
	add	x0, sp, #16
	str	x8, [sp, #16]
Ltmp0:
	bl	__ZN3std2rt10lang_start28_$u7b$$u7b$closure$u7d$$u7d$17h0fc9c5d33563953aE
	str	w0, [sp, #12]
Ltmp1:
	b	LBB2_5
LBB2_2:
	b	LBB2_4
LBB2_3:
Ltmp2:
	mov	x8, x1
	stur	x0, [x29, #-16]
	stur	w8, [x29, #-8]
	b	LBB2_2
LBB2_4:
	ldur	x0, [x29, #-16]
	bl	__Unwind_Resume
LBB2_5:
	ldr	w0, [sp, #12]
	ldp	x29, x30, [sp, #48]
	add	sp, sp, #64
	ret
Lfunc_end0:
	.cfi_endproc
	.section	__TEXT,__gcc_except_tab
	.p2align	2
GCC_except_table2:
Lexception0:
	.byte	255
	.byte	255
	.byte	1
	.uleb128 Lcst_end0-Lcst_begin0
Lcst_begin0:
	.uleb128 Ltmp0-Lfunc_begin0
	.uleb128 Ltmp1-Ltmp0
	.uleb128 Ltmp2-Lfunc_begin0
	.byte	0
	.uleb128 Ltmp1-Lfunc_begin0
	.uleb128 Lfunc_end0-Ltmp1
	.byte	0
	.byte	0
Lcst_end0:
	.p2align	2

	.section	__TEXT,__text,regular,pure_instructions
	.p2align	2
__ZN4core3ptr85drop_in_place$LT$std..rt..lang_start$LT$$LP$$RP$$GT$..$u7b$$u7b$closure$u7d$$u7d$$GT$17h60195690429a27a3E:
	.cfi_startproc
	ret
	.cfi_endproc

	.p2align	2
__ZN1h4main17h6ef1a55e67422aafE:
	.cfi_startproc
	ret
	.cfi_endproc

	.p2align	2
__ZN4core4hint9black_box17h0662204d533caa29E:
	.cfi_startproc
	; InlineAsm Start
	; InlineAsm End
	ret
	.cfi_endproc

	.p2align	2
__ZN54_$LT$$LP$$RP$$u20$as$u20$std..process..Termination$GT$6report17hbaf5a0d162093e04E:
	.cfi_startproc
	sub	sp, sp, #32
	stp	x29, x30, [sp, #16]
	add	x29, sp, #16
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	mov	w0, #0
	bl	__ZN68_$LT$std..process..ExitCode$u20$as$u20$std..process..Termination$GT$6report17h141d3021e282d64dE
	stur	w0, [x29, #-4]
	ldur	w0, [x29, #-4]
	ldp	x29, x30, [sp, #16]
	add	sp, sp, #32
	ret
	.cfi_endproc

	.p2align	2
__ZN68_$LT$std..process..ExitCode$u20$as$u20$std..process..Termination$GT$6report17h141d3021e282d64dE:
	.cfi_startproc
	sub	sp, sp, #32
	stp	x29, x30, [sp, #16]
	add	x29, sp, #16
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	mov	x8, x0
	sub	x0, x29, #1
	sturb	w8, [x29, #-1]
	bl	__ZN3std3sys4unix7process14process_common8ExitCode6as_i3217h907f925cc51091dfE
	str	w0, [sp, #8]
	ldr	w0, [sp, #8]
	ldp	x29, x30, [sp, #16]
	add	sp, sp, #32
	ret
	.cfi_endproc

	.private_extern	__ZN3std2rt10lang_start17h31d5a2ce2e61e8a8E
	.globl	__ZN3std2rt10lang_start17h31d5a2ce2e61e8a8E
	.p2align	2
__ZN3std2rt10lang_start17h31d5a2ce2e61e8a8E:
	.cfi_startproc
	sub	sp, sp, #48
	stp	x29, x30, [sp, #32]
	add	x29, sp, #32
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	mov	x8, x0
	str	x1, [sp, #8]
	mov	x3, x2
	ldr	x2, [sp, #8]
	sub	x0, x29, #8
	stur	x8, [x29, #-8]
	adrp	x1, l___unnamed_1@PAGE
	add	x1, x1, l___unnamed_1@PAGEOFF
	bl	__ZN3std2rt19lang_start_internal17hdb95dc8049556d44E
	str	x0, [sp, #16]
	ldr	x0, [sp, #16]
	ldp	x29, x30, [sp, #32]
	add	sp, sp, #48
	ret
	.cfi_endproc

	.p2align	2
__ZN3std2rt10lang_start28_$u7b$$u7b$closure$u7d$$u7d$17h0fc9c5d33563953aE:
	.cfi_startproc
	sub	sp, sp, #32
	stp	x29, x30, [sp, #16]
	add	x29, sp, #16
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	ldr	x0, [x0]
	bl	__ZN3std10sys_common9backtrace28__rust_begin_short_backtrace17h3c0f27d087d6ed83E
	bl	__ZN54_$LT$$LP$$RP$$u20$as$u20$std..process..Termination$GT$6report17hbaf5a0d162093e04E
	stur	w0, [x29, #-4]
	ldur	w0, [x29, #-4]
	ldp	x29, x30, [sp, #16]
	add	sp, sp, #32
	ret
	.cfi_endproc

	.p2align	2
__ZN3std10sys_common9backtrace28__rust_begin_short_backtrace17h3c0f27d087d6ed83E:
Lfunc_begin1:
	.cfi_startproc
	.cfi_personality 155, _rust_eh_personality
	.cfi_lsda 16, Lexception1
	sub	sp, sp, #32
	stp	x29, x30, [sp, #16]
	add	x29, sp, #16
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	bl	__ZN4core3ops8function6FnOnce9call_once17h17d09da0f6c5b02bE
Ltmp3:
	bl	__ZN4core4hint9black_box17h0662204d533caa29E
Ltmp4:
	ldp	x29, x30, [sp, #16]
	add	sp, sp, #32
	ret
LBB10_3:
	b	LBB10_5
LBB10_4:
Ltmp5:
	mov	x8, x1
	str	x0, [sp]
	str	w8, [sp, #8]
	b	LBB10_3
LBB10_5:
	ldr	x0, [sp]
	bl	__Unwind_Resume
Lfunc_end1:
	.cfi_endproc
	.section	__TEXT,__gcc_except_tab
	.p2align	2
GCC_except_table10:
Lexception1:
	.byte	255
	.byte	255
	.byte	1
	.uleb128 Lcst_end1-Lcst_begin1
Lcst_begin1:
	.uleb128 Lfunc_begin1-Lfunc_begin1
	.uleb128 Ltmp3-Lfunc_begin1
	.byte	0
	.byte	0
	.uleb128 Ltmp3-Lfunc_begin1
	.uleb128 Ltmp4-Ltmp3
	.uleb128 Ltmp5-Lfunc_begin1
	.byte	0
	.uleb128 Ltmp4-Lfunc_begin1
	.uleb128 Lfunc_end1-Ltmp4
	.byte	0
	.byte	0
Lcst_end1:
	.p2align	2

	.section	__TEXT,__text,regular,pure_instructions
	.p2align	2
__ZN3std3sys4unix7process14process_common8ExitCode6as_i3217h907f925cc51091dfE:
	.cfi_startproc
	ldrb	w0, [x0]
	ret
	.cfi_endproc

	.globl	_main
	.p2align	2
_main:
	.cfi_startproc
	stp	x29, x30, [sp, #-16]!
	mov	x29, sp
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	mov	x2, x1
	mov	x8, x0
	sxtw	x1, w8
	adrp	x0, __ZN1h4main17h6ef1a55e67422aafE@PAGE
	add	x0, x0, __ZN1h4main17h6ef1a55e67422aafE@PAGEOFF
	bl	__ZN3std2rt10lang_start17h31d5a2ce2e61e8a8E
	ldp	x29, x30, [sp], #16
	ret
	.cfi_endproc

	.section	__DATA,__const
	.p2align	3
l___unnamed_1:
	.quad	__ZN4core3ptr85drop_in_place$LT$std..rt..lang_start$LT$$LP$$RP$$GT$..$u7b$$u7b$closure$u7d$$u7d$$GT$17h60195690429a27a3E
	.asciz	"\b\000\000\000\000\000\000\000\b\000\000\000\000\000\000"
	.quad	__ZN4core3ops8function6FnOnce40call_once$u7b$$u7b$vtable.shim$u7d$$u7d$17h206b2bf18a36c8ceE
	.quad	__ZN3std2rt10lang_start28_$u7b$$u7b$closure$u7d$$u7d$17h0fc9c5d33563953aE
	.quad	__ZN3std2rt10lang_start28_$u7b$$u7b$closure$u7d$$u7d$17h0fc9c5d33563953aE

.subsections_via_symbols
